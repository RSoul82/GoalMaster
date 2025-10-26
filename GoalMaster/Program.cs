using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace GoalMaster
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            if (args.Length == 1)
            {
                int missionNumber = 0;
                Int32.TryParse(args[0], out missionNumber);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(missionNumber));
            }
            else if (args.Length == 4)
            {
                if (File.Exists(args[0])) //cmd file
                {
                    File.Copy(args[0], args[1], true);
                    File.Delete(args[0]);
                }
                if (File.Exists(args[2])) //goals.str
                {
                    //Create dest dir if it does not exist
                    string goalsDir = Path.GetDirectoryName(args[3]);
                    if (!Directory.Exists(goalsDir)) Directory.CreateDirectory(goalsDir);

                    File.Copy(args[2], args[3], true);
                    File.Delete(args[2]);
                }
            }
        }

        internal static void copyFiles(string src1, string dst1, string src2, string dst2)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
	        startInfo.UseShellExecute = true;
	        startInfo.WorkingDirectory = Environment.CurrentDirectory;

	        Uri uri = new Uri(Assembly.GetExecutingAssembly().GetName().CodeBase);
	        startInfo.FileName = uri.LocalPath;

            string args = String.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\"", src1, dst1, src2, dst2);
	
	        startInfo.Arguments = args;
	        startInfo.Verb = "runas";

	        Process p = Process.Start(startInfo);
	        p.WaitForExit();
        }
    }
}
