namespace LibSysConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
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
                        Console.WriteLine("Option 1");
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
