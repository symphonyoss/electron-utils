using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOnBoot
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];

            if (Directory.Exists(path))
            {
                try
                {
                    Directory.Delete(path, true);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Clearing process failed: {0}", e.Message);
                }
            }
        }
    }
}
