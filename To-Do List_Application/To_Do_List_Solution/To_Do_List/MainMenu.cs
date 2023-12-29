using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal static class MainMenu
    {
        public static bool MenuOptions()
        {
            Console.Clear();
            Console.WriteLine("===== To-Do List App =====");
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Enter to select: ");

            switch(Console.ReadLine())
            {
                case "1":
                    TasksService.ViewTasks();
                    return true;
                case "2":
                    TasksService.AddTask();
                    return true;
                case "3":
                    TasksService.CompleteTask();
                    return true;
                case "4":
                    TasksService.DeleteTask();
                    return true;
                case "5":
                    // Exit();
                    return false;
                default:
                    return true;
            }
        }
    }
}

