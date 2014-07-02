using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace POETrivia
{
    public partial class MainForm : Form
    {
        private readonly SQLite _sqLite = new SQLite();
        public MainForm()
        {
            InitializeComponent();
            readTimer.Start();
            categoriesListBox.DataSource = _sqLite.QueryCategories();
        }

        private void ParseLine()
        {

        }

        private void PopulateCategories()
        {
            
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

        /// <summary> Determines if the current line is one that contains chat </summary>
        /// <param name="line">Input line as string</param>
        private static bool IsChat(string line)
        {
            return line.Split(' ')[3].Equals("1f3");
        }

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
                        if (ParseDate(currentLine).Date == DateTime.Now.Date && IsChat(currentLine)) Console.WriteLine(currentLine);
                    }
                    while (sr.EndOfStream) Thread.Sleep(100);
                }
            }
        }

        private void readTimer_Tick(object sender, EventArgs e)
        {
            if (!chatBGW.IsBusy)chatBGW.RunWorkerAsync();
        }

        public void AddStatus(string status)
        {
            statusValueLabel.Text = status;

        }

        private void categoriesListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) categoriesContextMenu.Show(MousePosition.X, MousePosition.Y);
            PostMessage();
        }

        private void PostMessage()
        {
            //var processes = Process.GetProcessesByName("PathOfExile");
            var processes = Process.GetProcessesByName("Notepad");
            foreach (Process P in processes)
            {
                //if (P.ProcessName == "PathOfExile")
                if (P.ProcessName == "notepad")
                {
                    //PostMessage(P.MainWindowHandle, WM_KEYDOWN, (int)Keys.F5, 0);
                    Clipboard.SetText("Hello World!");
                    PostMessage(P.MainWindowHandle, WM_PASTE, (int)Keys.F5, 0);
                }
            }
        }

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        private const UInt32 WM_KEYDOWN = 0x0100;
        private const UInt32 WM_PASTE = 0x302;
        private const UInt32 WM_KEYUP = 0x0101;

        public static void SendSelect(IntPtr HWnd)
        {
            PostMessage(HWnd, WM_KEYDOWN, (int)Keys.W, 0);
        }

        
        [DllImport("user32.dll", EntryPoint="FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

    }
}
