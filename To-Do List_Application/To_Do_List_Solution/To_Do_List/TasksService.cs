
namespace ToDoList
{
    internal static class TasksService
    {
        private static List<string> tasks = new List<string>();

        public static void ViewTasks()
        {
            Console.Clear();
            TasksUtils.DisplayListOfTasks(tasks);
            Console.ReadLine();
        }
        public static void AddTask()
        {
            Console.Clear();
            Console.WriteLine("Adding task");

            string addInput = TasksUtils.CaptureInputAddTask();

            if (string.IsNullOrEmpty(addInput))
            {
                Console.WriteLine("Task cannot be empty");
                Console.ReadLine();
            }
            else
            {
                tasks.Add(addInput);
                TasksUtils.DisplayAddedTaskResult(addInput);
            }
        }

        public static void CompleteTask()
        {
            Console.Clear();
            Console.WriteLine("Completing task");

            TasksUtils.DisplayListOfTasks(tasks);

            int completeInput = TasksUtils.CaptureInputCompleteTask();

            if (completeInput >= 0 && completeInput < tasks.Count)
            {
                tasks[completeInput] += " (Completed)";
            }

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        public static void DeleteTask()
        {
            Console.Clear();

            Console.WriteLine("Removing task");

            TasksUtils.DisplayListOfTasks(tasks);
            int removeInput = TasksUtils.CaptureInputDeleteTask();
            tasks.RemoveAt(removeInput);

            Console.WriteLine($"Task #{removeInput + 1} was removed");
            Console.Write("\r\nPress Enter to return to Main Menu");

            Console.ReadLine();

        }
    }
}
