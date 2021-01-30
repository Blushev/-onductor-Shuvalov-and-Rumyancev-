using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp4
{
    class Commands
    {
        public void Delete(string path)
        {
            Console.WriteLine("Что хотите удалить?");
            string file = Console.ReadLine();
            FileInfo fileInf = new FileInfo(path + "\\" + file);
            DirectoryInfo dirInfo = new DirectoryInfo(path + "\\" + file);
            if (dirInfo.Exists)
            {
                dirInfo.Delete();
            }
            else if (fileInf.Exists)
            {
                fileInf.Delete();
            }
            else
            {
                Console.WriteLine("Вы ввели неверную папку!");
            }
        }
        public void Create(string path)
        {
            Console.Write("Воссоздаём файл! Придумайте имя: ");
            string file = Console.ReadLine();
            FileInfo fileInf = new FileInfo(path + "\\" + file);
            if (!fileInf.Exists)
            {
                fileInf.Create();
            }
        }
        public string Cd(string path)
        {
            Console.WriteLine("В какую папку вы хотите перейти? (Back - вернуться)");
            string pathFile = Console.ReadLine();
            if (pathFile == "Back")
            {
                string newPathFile = Convert.ToString(Directory.GetParent(path));
                return newPathFile;
            }
            else
            {
                string newPathFile = path + "\\" + pathFile;
                return newPathFile;
            }
            Console.ReadKey();
        }
    }
}
