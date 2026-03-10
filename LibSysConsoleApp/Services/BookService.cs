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

        public void FindAndRemoveBook()
        {
            Console.Write("Title: \r\t");
            string title = Console.ReadLine();

            var foundBooks = _books
                .Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!foundBooks.Any())
            {
                Console.WriteLine("No books found.");
                Thread.Sleep(3000);
                Console.Clear();
                return;
            }

            Console.WriteLine("\nFound books:");
            foreach (var book in foundBooks)
            {
                Console.WriteLine($"ID: {book.Id}");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Borrowed: {(book.IsBorrowed ? "Yes" : "No")}");
                Console.WriteLine("------------------------------");
            }

            Console.Write("Enter ID of the book you want to remove: \t");

            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var bookToRemove = foundBooks.FirstOrDefault(b => b.Id == id);

                if (bookToRemove == null)
                {
                    Console.WriteLine("There is no book with that ID in the search results.");
                }

                else if (bookToRemove.IsBorrowed)
                {
                    Console.WriteLine("This book is currently borrowed and cannot be removed.");
                }

                else
                {
                    _books.Remove(bookToRemove);
                    Console.WriteLine("Book removed successfully.");
                }
            }

            else
            {
                Console.WriteLine("Invalid ID.");
            }

            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}
