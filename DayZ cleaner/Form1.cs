using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayZ_cleaner
{
    public partial class Form1 : Form
    {
        private static List<string> fileExts = new List<string>(){ "mdmp", "rpt", "log" };
        List<string> files = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            findFiles();
        }

        private void okButton_Click(object sender, EventArgs e) => deleteFiles();
        private void cancelButton_Click(object sender, EventArgs e) => Application.Exit();

        async Task deleteFiles()
        {
            foreach (var file in files)
            {
                try
                {
                    new FileInfo(file).Delete();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            Application.Exit();
        }
        async Task findFiles()
        {
            var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\DayZ\\";
            
            long fileSize = 0;

            foreach (var fileExt in fileExts) files.AddRange(Directory.GetFiles(path, $"*.{fileExt}"));
            foreach (var file in files) fileSize += new FileInfo(file).Length;
            
            await Task.Delay(1);
            ResultTextBox.Text = $"Found {files.Count} files with a size of {BytesToPrettyString(fileSize)}.";
        }

        public static string BytesToPrettyString(object Size) => ConvertBytesToPrettyString((float)Convert.ToDouble(Size), 0);
        public static string BytesToPrettyString(double Size) => ConvertBytesToPrettyString((float)Size, 0);
        public static string BytesToPrettyString(float Size) => ConvertBytesToPrettyString(Size, 0);
        public static string BytesToPrettyString(int Size) => ConvertBytesToPrettyString(Size, 0);

        private static string ConvertBytesToPrettyString(float Size, int R)
        {
            float F = Size / 1024f;
            if (F < 1)
            {
                switch (R)
                {
                    case 0:
                        return string.Format("{0:0.00} byte", Size);
                    case 1:
                        return string.Format("{0:0.00} kb", Size);
                    case 2:
                        return string.Format("{0:0.00} mb", Size);
                    case 3:
                        return string.Format("{0:0.00} gb", Size);
                    case 4:
                        return string.Format("{0:0.00} tb", Size);
                }
            }
            return ConvertBytesToPrettyString(F, ++R);
        }
        private void ZombieToastLinkLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ZombieToast.de");
        }

        private void DiscordPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/hYnRxtC");
        }
    }
}
