using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibSysConsoleApp.Models;

namespace LibSysConsoleApp.Services
{
    public class BookService
    {
        private List<Book> _books = new List<Book>();
        int idCounter = 1;

        public void AddBook()
        {
            int id = idCounter++;

            Console.Write("Title: \r\t");
            string title = Console.ReadLine();

            Console.Write("Author: \r\t");
            string author = Console.ReadLine();

            _books.Add(new Book(id, title, author));

            Console.WriteLine($"You are adding '{title}' by {author} with an ID: {id}");
            Thread.Sleep(3000);
            Console.Clear();
        }

        public void PrintAllBooks()
        {
            foreach (var book in _books)
            {
                Console.WriteLine($"ID: {book.Id}");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine("------------------------------");
            }
        }

        public void RemoveBook()
        {
            
        }
    }
}
