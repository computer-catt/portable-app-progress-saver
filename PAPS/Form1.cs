using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PAPS
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                TF2Man.BackgroundImageLayout = ImageLayout.Zoom;
                TF2Man.BackgroundImage = Bitmap.FromStream(WebRequest.Create("https://cdn.discordapp.com/attachments/1104813377836036237/1164212783307571350/IMG_1945.jpg").GetResponse().GetResponseStream());
            }
            catch 
            {

                Directories.Width += TF2Man.Width;
                TF2Man.Hide();
                Directories.Location = TF2Man.Location;
            }
        }


        private string CreateShortcut(string exe, string path, string iconloc, string arguments, string prefix = "")
        {
            if (prefix.Length != 0)
                prefix += " ";
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            string shortcutpath = path + "\\" + prefix + Functions.GetLastDirectoryName(iconloc).Split('.')[0] + ".lnk";
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
                appdatapath.Text = openfolder.ResultPath;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            try
            {
                Tabs.SelectedTab = Logtab;
                log(exepath.ForeColor == Color.Green ? "Exe path is valid." : "Exe path is not valid.");
                log(appdatapath.ForeColor == Color.Green ? "App data path is valid." : "App data path is not valid.");
                log("Replacing variables...");
                string appdatafolder = appdatapath.Text.Replace(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "%UserProfile%");
                string exepathv2 = exepath.Text.Replace(Directory.GetDirectoryRoot(exepath.Text), "%nyapath%");
                log("creating shortcut");
                string[] arguments =
                    {
                exepathv2,
                appdatafolder,
                Fbimode.Checked.ToString(),
                DelayNum.Text,
                Pause.Checked.ToString(),
                consoletoggle.Checked.ToString(),
                SaveSlot.Text
                };

                string args = "";
                foreach (string arg in arguments)
                    args += "\"" + arg.TrimEnd('\\') + "\" ";

                if (File.Exists(CreateShortcut(Path.GetFullPath(Process.GetCurrentProcess().ProcessName), Path.GetDirectoryName(exepath.Text), exepath.Text, args, SaveSlot.Text)))
                    log("shortcut created");
                else
                    log("error occured creating shortcut and shortcut wasnt created");
                log("Process has finished.");
            }
            catch (Exception error)
            {
                log(error.ToString());
            }
        }


        void log(string text) => GeneralLog.Text += text + "\n";

        private void exepath_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(exepath.Text))
                exepath.ForeColor = File.Exists(exepath.Text) ? Color.Green : Color.Red;
        }

        private void appdatapath_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(appdatapath.Text))
                appdatapath.ForeColor = Directory.Exists(appdatapath.Text) ? Color.Green : Color.Red;
        }

        private void DelayNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        bool scanon;
        private void ScannerButton_Click(object sender, EventArgs e)
        {
            if (scanon)
            {
                foreach (Process thing in Process.GetProcessesByName(Path.GetFileName(exepath.Text)))
                    thing.Kill();
                scanon = false;
                ScannerButton.FlatStyle = FlatStyle.Standard;
                ScannerButton.BackColor = SystemColors.Control;
                ScannerButton.ForeColor = SystemColors.ControlText;
                ScannerButton.Text = "Run";

            }
            else
            {
                FileSystemWatcher watcher = new FileSystemWatcher();
                watcher.Path = Environment.ExpandEnvironmentVariables(fetchpath.Text);
                watcher.NotifyFilter = NotifyFilters.Attributes
                                     | NotifyFilters.CreationTime
                                     | NotifyFilters.DirectoryName
                                     | NotifyFilters.FileName
                                     | NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.Security
                                     | NotifyFilters.Size;
                watcher.EnableRaisingEvents = true;
                watcher.IncludeSubdirectories = true;
                watcher.Created += Watcher_event;
                watcher.Deleted += Watcher_event;
                watcher.Renamed += Watcher_event;
                watcher.Changed += Watcher_event;
                if (launchapptoggle.Checked)
                    if (exepath.ForeColor == Color.Green)
                    {
                        Process application = new Process();
                        application.StartInfo.WorkingDirectory = Path.GetDirectoryName(exepath.Text);
                        application.StartInfo.FileName = Path.GetFileName(exepath.Text);
                        application.Start();
                    }
                scanon = true;
                ScannerButton.FlatStyle = FlatStyle.Flat;
                ScannerButton.BackColor = Color.Black;
                ScannerButton.ForeColor = Color.Red;
                ScannerButton.Text = "Stop";
            }
        }

        private void Watcher_event(object sender, FileSystemEventArgs e)
        {
            bool log = true;
            foreach (string blacklisted in blacklist.Text.Split('\n'))
                if (blacklisted.Trim().Length > 0)
                    if (e.FullPath.Contains(blacklisted.Trim()))
                    {
                        log = false;
                        break;
                    }
            if (log)
            {
                fetchlist.Items.Add(e.FullPath + " - " + e.ChangeType);
                fetchlist.TopIndex = fetchlist.Items.Count - 1;
            }
        }

        private void fetchlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempy = Path.GetDirectoryName(fetchlist.Text.ToString().Split('-')[0]);
            if (modetoggle.Text.Contains("Apply"))
            {
                Tabs.SelectedTab = Settingstab;
                appdatapath.Text = tempy;
            }
            else
                Clipboard.SetText(tempy);
        }

        private void ADLshortcut_Click(object sender, EventArgs e) => Tabs.SelectedTab = Loggertab;

        private void modetoggle_Click(object sender, EventArgs e)
        {
            modetoggle.Text = modetoggle.Text.Contains("Apply") ? "Mode: Copy" : "Mode: Apply";
        }
    }
}
