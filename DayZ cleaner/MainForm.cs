using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayZ_cleaner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static readonly List<string> fileExts = new List<string> {"mdmp", "rpt", "log", "ch"};
        private readonly List<string> files = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //findFiles();
            Task.Run(() => findFiles());
        }

        private void okButton_Click(object sender, EventArgs e) => deleteFiles();
        private void cancelButton_Click(object sender, EventArgs e) => Application.Exit();

        private async Task deleteFiles()
        {
            var cleanedCounter = 0;
            foreach (var file in files)
            {
                try
                {
                    new FileInfo(file).Delete();
                    cleanedCounter++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            MessageBox.Show($"cleaned {cleanedCounter} / {files.Count}");
            Application.Exit();
        }

        private async Task findFiles()
        {
            var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\DayZ\\";

            long fileSize = 0;
            var fileCount = 0;

            foreach (var fileExt in fileExts)
            {
                files.AddRange(Directory.GetFiles(path, $"*.{fileExt}", SearchOption.AllDirectories));
            }

            foreach (var file in files)
            {
                fileSize += new FileInfo(file).Length;
                fileCount++;
                ResultTextBox.Invoke((MethodInvoker)delegate { ResultTextBox.Text = $"Found {fileCount} files with a size of {BytesToPrettyString(fileSize)}."; });
            }
            await Task.Delay(1);
            okButton.Invoke((MethodInvoker)delegate { okButton.Enabled = true; });            
        }

        public static string BytesToPrettyString(float Size) => ConvertBytesToPrettyString(Size, 0);

        private static string ConvertBytesToPrettyString(float Size, int R)
        {
            var F = Size / 1024f;
            if (F < 1)
            {
                switch (R)
                {
                    case 0:
                        return $"{Size:0.00} byte";
                    case 1:
                        return $"{Size:0.00} kb";
                    case 2:
                        return $"{Size:0.00} mb";
                    case 3:
                        return $"{Size:0.00} gb";
                    case 4:
                        return $"{Size:0.00} tb";
                }
            }

            return ConvertBytesToPrettyString(F, ++R);
        }

        private void ZombieToastLinkLabel_Click(object sender, EventArgs e)
        {
            Process.Start("http://ZombieToast.de");
        }

        private void DiscordPictureBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/hYnRxtC");
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ResultTextBox.Refresh();
        }
    }
}