using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp4
{
    class WorkingConsole
    {
        public void Paint(string path)
        {
            if (Directory.Exists(path))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(path);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                string[] files = Directory.GetFiles(path);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
