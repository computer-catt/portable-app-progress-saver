using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
//using IWshRuntimeLibrary;

namespace PAPS
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox1.BackgroundImage = Bitmap.FromStream(WebRequest.Create("https://cdn.discordapp.com/attachments/1104813377836036237/1164212783307571350/IMG_1945.jpg").GetResponse().GetResponseStream());
            }
            catch 
            {
                pictureBox1.Hide();
                panel1.Location = pictureBox1.Location;
            }
        }


        private string CreateShortcut(string exe, string path, string iconloc, string arguments)
        {
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();

            string shortcutpath = path + "\\" + Functions.GetLastDirectoryName(iconloc).Split('.')[0] + ".lnk";
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutpath);
            shortcut.Arguments = arguments;
            shortcut.TargetPath = exe;
            shortcut.WorkingDirectory = path;
            shortcut.IconLocation = iconloc;
            shortcut.Save();
            return shortcutpath;
        }

        private void exepathbrowse_Click(object sender, EventArgs e)
        {
            if (openfile.ShowDialog() == DialogResult.OK) 
                exepath.Text = openfile.FileName;
        }

        private void appdatapathbrowse_Click(object sender, EventArgs e)
        {
            openfolder openfolder = new openfolder
            {
                Multiselect = false
            };
            if (openfolder.ShowDialog(IntPtr.Zero) == true)
            {
                appdatapath.Text = openfolder.ResultPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log(exepath.ForeColor == Color.Green ? "Exe path is valid." : "Exe path is not valid.");
            log(appdatapath.ForeColor == Color.Green ? "App data path is valid." : "App data path not is valid.");
            log("Delete files after app close: " + Fbimode.Checked);
            log("Replacing variables...");
            string appdatafolder = appdatapath.Text.Replace(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "%UserProfile%");
            string exepathv2 = exepath.Text.Replace(Directory.GetDirectoryRoot(exepath.Text), "%nyaroot%");
            log("creating shortcut");
            if (File.Exists(CreateShortcut(Path.GetFullPath(Process.GetCurrentProcess().ProcessName),Path.GetDirectoryName(exepath.Text), exepath.Text, "\"" + exepathv2 + "\" \"" + appdatafolder + "\" \"" + Fbimode.Checked.ToString() + "\"")))
            {
                log("shortcut created");
            }
            else
            {
                log("error occured creating shortcut and shortcut wasnt created");
            }
            log("Process has finished.");
        }


        void log(string text)
        {
            richTextBox1.Text += text + "\n";
        }

        private void exepath_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(exepath.Text))
            {
                exepath.ForeColor = File.Exists(exepath.Text) ? Color.Green : Color.Red;
            }
        }

        private void appdatapath_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(appdatapath.Text))
            {
                appdatapath.ForeColor = Directory.Exists(appdatapath.Text) ? Color.Green : Color.Red;
            }
        }
    }
}
