using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Logic
    {
        public void Start()
        {
            string path = @"C:\Новая папка";
            bool boolCheck = true;
            WorkingConsole workConsole = new WorkingConsole();
            Commands commands = new Commands();
            while (boolCheck)
            {
                string new_path = "";
                workConsole.Paint(path);
                string user_command = "Какую команду вы хотите ввести? \nDelete, Create, Cd";
                Console.WriteLine(user_command);
                string command = Console.ReadLine();
                switch (command)
                {
                    case "Delete":
                        commands.Delete(path);
                        break;
                    case "Create":
                        commands.Create(path);
                        break;
                    case "Cd":
                        new_path = commands.Cd(path);
                        break;
                    default:
                        Console.WriteLine("Вы еблан!");
                        Console.ReadKey();
                        break;
                }
                if (new_path != "")
                {
                    path = new_path;
                }
                Console.Clear();
            }
        }
    }
}