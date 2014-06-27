using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace POETrivia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            readTimer.Start();
        }

        private void ParseLine()
        {

        }

        private static DateTime ParseDate(string line)
        {
            var splitDate = line.Split(' ')[0];
            var splitTime = line.Split(' ')[1];
            var dateTime = Convert.ToDateTime(splitDate + " " + splitTime);
            return dateTime;
        }

        private static bool ParseChat(string line)
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
                        if (ParseDate(currentLine).Date == DateTime.Now.Date && ParseChat(currentLine)) Console.WriteLine(currentLine);
                    }
                    while (sr.EndOfStream) Thread.Sleep(100);
                }
            }
        }

        private void readTimer_Tick(object sender, EventArgs e)
        {
            if (!chatBGW.IsBusy)chatBGW.RunWorkerAsync();
        }
    }
}
