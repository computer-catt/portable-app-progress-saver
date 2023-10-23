using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAPS
{
    internal static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                ShowWindow(GetConsoleWindow(), 0);
                Application.Run(new Form1());
            }
            else
            {
                if (!Convert.ToBoolean(args[5]))
                {
                    ShowWindow(GetConsoleWindow(), 0);
                }
                string exepath = args[0].Replace("%nyapath%", Directory.GetDirectoryRoot(Directory.GetCurrentDirectory()));
                string appdatapath = args[1];
                string appname = Functions.GetLastDirectoryName(appdatapath);
                string appdatalocation = appdatapath.Replace(appname, "");
                string root = Path.GetDirectoryName(exepath);
                string backupfolder = root + @"\portable\" + appname;
                Console.WriteLine("exe: " + exepath);
                Console.WriteLine("app data path: " + appdatapath);
                Console.WriteLine("app name: " + appname);
                Console.WriteLine("backup folder: " + backupfolder);
                Console.WriteLine("appdata location: " + appdatalocation);
                if (!Directory.Exists(backupfolder))
                {
                    Console.WriteLine("no backup folder(first setup maybe?), trying to fetch.");
                    if (Directory.Exists(appdatapath))
                        Functions.CopyFilesRecursively(appdatapath, backupfolder);
                    else
                        Console.WriteLine("no data found at all.");
                }
                else
                {
                    Console.WriteLine("data found localy.");
                    if (Directory.Exists(appdatapath))
                        Directory.Delete(appdatapath, true);
                    Functions.CopyFilesRecursively(backupfolder, appdatapath);
                }
                Thread.Sleep(500);
                Console.WriteLine("starting: " + Functions.GetLastDirectoryName(exepath));
                Process asparagus = new Process();
                asparagus.StartInfo.FileName = exepath;
                asparagus.StartInfo.WorkingDirectory = root;
                asparagus.Start();
                asparagus.WaitForExit();
                Thread.Sleep(int.Parse(args[3]));
                Console.WriteLine("Saving app data.");
                Functions.CopyFilesRecursively(appdatapath, backupfolder);
                Console.WriteLine("App data saved.");
                if (Convert.ToBoolean(args[2]))
                {
                    Console.WriteLine("Selected to delete saved data from pc..\ndeleting..");
                    if (Directory.Exists(appdatapath))
                        Directory.Delete(appdatapath, true);
                }
                if (Convert.ToBoolean(args[4]))
                {
                    ShowWindow(GetConsoleWindow(), 5);
                    Console.WriteLine("Pause specified.");
                    Console.ReadLine();
                }
            }
        }
    }
}