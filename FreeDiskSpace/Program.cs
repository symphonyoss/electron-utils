using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FreeDiskSpace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var driveInfo = DriveInfo.GetDrives().ToDictionary(drive => drive.Name);

            foreach (var drive in args
                .Select(arg => arg.ToUpperInvariant())
                .Select(parts => parts[0] + ":\\"))
            {
                DriveInfo drive_status = null;
                if (driveInfo.TryGetValue(drive, out drive_status))
                {
                    Console.WriteLine(
                        (drive_status.IsReady ? drive_status.TotalFreeSpace : 0L) + "," +
                        (drive_status.IsReady ? "READY" : "NOT_READY"));
                }
                else
                {
                    Console.WriteLine("0,DISK_NOT_FOUND");
                }
            }
        }
    }
}