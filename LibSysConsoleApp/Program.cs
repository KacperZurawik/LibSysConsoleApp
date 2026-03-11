using LibSysConsoleApp.Services;

namespace LibSysConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookService bookService = new BookService();

            Console.WriteLine("LibSys - Library Management System");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");

            bool isAppRunning = true;
            while (isAppRunning)
            {
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Show all books");
                Console.WriteLine("3. Remove book");
                Console.WriteLine("4. Exit");

                string menuOption = Console.ReadLine();

            
                switch (menuOption)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Operation: Add book \n-------------------");
                        bookService.AddBook();      
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Operation: Show all books \n-------------------");
                        bookService.PrintAllBooks();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Operation: Remove book \n-------------------");
                        bookService.FindAndRemoveBook();
                        break;

                    case "4":
                        Console.WriteLine("Goodbye!");
                        isAppRunning = false;
                        break;

                    default:
                        Console.WriteLine("There is no such option. Please chose between 1 and 4.");
                        break;

                        //test
                }
            }
        }
    }
}
