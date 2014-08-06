using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;

namespace POETrivia
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public readonly SQLite _sqLite = new SQLite();
        private static MainForm _mainForm;
        private EditQuestions _editQuestions;
        public Dictionary<string, int> _categories = new Dictionary<string, int>();
        public MainForm()
        {
            InitializeComponent();
            readTimer.Start();
            _mainForm = this;
            _categories = _sqLite.QueryCategories();
            categoriesListBox.DataSource = _categories.Keys.ToList();
        }

        #region Custom Methods

        public static MainForm GetSingleton()
        {
            return _mainForm;
        }

        /// <summary>Parses the date time from a string to a DateTime </summary>
        /// <param name="line">Input string</param>
        /// <returns> The DateTime of the input string</returns>
        private static DateTime ParseDate(string line)
        {
            var splitDate = line.Split(' ')[0];
            var splitTime = line.Split(' ')[1];
            var dateTime = Convert.ToDateTime(splitDate + " " + splitTime);
            return dateTime;
        }

        /// <summary> Determines if the current line is one that contains general chat </summary>
        /// <param name="line">Input line as string</param>
        private static bool IsGeneralChat(string line)
        {
            return line.Split(' ')[3].Equals("1f3") && line.Split(':')[2].Contains("#");
        }

        /// <summary> Determines if the current line is a whisper </summary>
        /// <param name="line">Input line as string</param>
        private static bool IsWhisper(string line)
        {
            return line.Split(':')[2].Contains("@");
        }

        /// <summary> Brings the PathOfExile process to the front and simulates chat message </summary>
        /// <param name="question">Question to be sent into chat</param>
        private static void SendQuestion(string question)
        {
            var p = Process.GetProcessesByName("PathOfExile");
            if (p.Any()) SetForegroundWindow(p[0].MainWindowHandle);
            InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
            InputSimulator.SimulateTextEntry(question);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
        }

        private static void ReturnWhisper(string account, string message)
        {
            var p = Process.GetProcessesByName("PathOfExile");
            if (p.Any()) SetForegroundWindow(p[0].MainWindowHandle);
            ClearChat();
            InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
            InputSimulator.SimulateTextEntry("@" + account + " " + message);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
        }

        /// <summary> Clears the chat of any whisper, channel or other descrepencies. </summary>
        private static void ClearChat()
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
            InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_A);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.DELETE);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
        }

        /// <summary> Updates the status strip and status list box </summary>
        /// <param name="status">Status to be set</param>
        public void AddStatus(string status)
        {
            statusValueLabel.Text = status;
            statusListBox.Items.Add(String.Format("[{0}] {1}", DateTime.Now.ToShortTimeString(), status));
        }

        private void ParseWhisper(string line)
        {
            var message = line.Split(':')[3].Trim();
            var whisperAccount = line.Split('@')[1].Split(':')[0];
            var givenPin = -1;
            if (message.Contains("!register"))
            {
                if (message.Split(' ').Count() == 3) givenPin = int.Parse(message.Split(' ')[2]);
                var pin = RegisterAccount(message.Split(' ')[1], givenPin);
                //if (pin > 0) ReturnWhisper(whisperAccount, @"Registration Successful, your login pin is: " + pin);
            }
            if (message.Contains("!login"))
            {
                if (message.Split().Count() == 3) givenPin = int.Parse(message.Split(' ')[2]);
                var account = message.Split(' ')[1];
                var userId = _sqLite.RetrieveId(account);
                if (givenPin != _sqLite.RetrievePin(userId)) return;
                if (_sqLite.CharacterExists(userId, whisperAccount))
                    MessageBox.Show(@"Login successful, this character has been linked to your account");
                else MessageBox.Show(@"Login successful, Welcome back " + account);
                //    ReturnWhisper(whisperAccount, @"Login successful, this character has been linked to your account");
                //else ReturnWhisper(whisperAccount, @"Login successful, Welcome back " + account);
            }
        }

        private int RegisterAccount(string account, int givenPin = 0)
        {
            var pin = new Random().Next(0000, 9999);
            _sqLite.RegisterAccount(account, givenPin > 0 ? givenPin : pin);
            return givenPin > 0 ? givenPin : pin;
        }
        #endregion

        private void chatBGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var logFile = new FileStream(@"C:\Users\M1nistry\Desktop\Games\Steam\SteamApps\common\Path of Exile\logs\Client.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (var sr = new StreamReader(logFile))
            {
                while (true)
                {
                    while (!sr.EndOfStream)
                    {
                        var currentLine = sr.ReadLine();
                        if (ParseDate(currentLine).Date != DateTime.Now.Date) return;
                        if (IsGeneralChat(currentLine)) Console.WriteLine(currentLine);
                        if (IsWhisper(currentLine)) ParseWhisper(currentLine);
                    }
                    while (sr.EndOfStream) Thread.Sleep(100);
                }
            }
        }

        private void readTimer_Tick(object sender, EventArgs e)
        {
            if (!chatBGW.IsBusy)chatBGW.RunWorkerAsync();
        }

        private void categoriesListBox_MouseDown(object sender, MouseEventArgs e)
        {
            categoriesListBox.SelectedIndex = categoriesListBox.IndexFromPoint(e.X, e.Y);
        }

        private void editQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_editQuestions != null && _editQuestions.Visible)
            {
                _editQuestions.Focus();
                System.Media.SystemSounds.Hand.Play();
            }
            else
            {
                _editQuestions = new EditQuestions();
                _editQuestions.FormClosed += (o, ea) => _editQuestions = null;
                _editQuestions.Show();
            }
        }

    }
}
