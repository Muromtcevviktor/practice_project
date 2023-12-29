namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;

            while(showMenu)
            {
                showMenu = MainMenu.MenuOptions();
            }
        }
    }
}