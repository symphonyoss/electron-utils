using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ClearSchTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];
            string schTaskName = args[1];
            int pid = Int32.Parse(args[2]);

            try
            {
                Process localById = Process.GetProcessById(pid);
                Console.Write("Process is running");
            }
            catch (Exception e)
            {
                if (Directory.Exists(path))
                {
                    try
                    {
                        Directory.Delete(path, true);
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("Clearing process failed: {0}", err.Message);
                    }
                }
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                string cmdArg = "/C schtasks /delete /tn '{0}' /f";
                string formattedCmd = string.Format(cmdArg, schTaskName);
                startInfo.Arguments = formattedCmd;
                process.StartInfo = startInfo;
                process.Start();
                Console.WriteLine(e.Message);
            }
        }
    }
}
