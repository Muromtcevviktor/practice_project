using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class TasksUtils
    {
        private static string[] taskStatus = new string[] { "Complete", "Incomplete" };
        public static string CaptureInputAddTask()
        {
            Console.Write("Enter task description: ");
            string captureInput = Console.ReadLine() + " (" + taskStatus[1] + ")";
            return captureInput;
        }

        public static void DisplayAddedTaskResult(string task)
        {
            Console.WriteLine($"\r\nYou added new task");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        public static void DisplayListOfTasks(List<string> tasks)
        {
            int count = 0;

            Console.WriteLine("Tasks:");

            foreach (var task in tasks)
            {
                count++;
                Console.Write(count + ". " + task);
                //Console.Write(count + ". " + task + " (");
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.Write(taskStatus[1]);
                //Console.ForegroundColor = ConsoleColor.Gray;
                //Console.WriteLine(")");
            }
        }

        public static int CaptureInputDeleteTask()
        {
            Console.WriteLine("Choose number of the task you want to remove: ");
            var inputIndex = Console.ReadLine();
            int convertDeleteIndex = int.Parse(inputIndex!) - 1;
            return convertDeleteIndex;
        }

        public static int CaptureInputCompleteTask()
        {
            Console.WriteLine("Choose number of the task you want to complete: ");
            var inputIndex = Console.ReadLine();
            int convertCompleteIndex = int.Parse(inputIndex!) - 1;
            
            return convertCompleteIndex;
        }
    }
}
