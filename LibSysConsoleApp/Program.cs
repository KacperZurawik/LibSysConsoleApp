using LibSysConsoleApp.Services;

namespace LibSysConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookService bookService = new BookService();

            bool isAppRunning = true;
            while (isAppRunning)
            {

                Console.WriteLine("LibSys - Library Management System");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("");

                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Exit");

                string menuOption = Console.ReadLine();

            
                switch (menuOption)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Operation: Add book \n-------------------");
                        bookService.AddBook();      
                        break;

                    case "2":
                        Console.WriteLine("Goodbye!");
                        isAppRunning = false;
                        break;

                    default:
                        Console.WriteLine("There is no such option. Please chose between 1 and 2.");
                        break;
                }
            }
        }
    }
}
