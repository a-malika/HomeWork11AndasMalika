using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Reader
    {
        public string Name { get; set; }
        public List<Book> RentedBooks { get; set; }
        public Reader(string name)
        {
            Name = name;
            RentedBooks = new List<Book>();
        }
        public void RentBook(Book book)
        {
            const int MaxBooks = 3;
            if (RentedBooks.Count >= MaxBooks)
            {
                Console.WriteLine($"{Name} cannot rent more than {MaxBooks} books.");
                return;
            }
            if (book.Status)
            {
                book.Status = false;
                RentedBooks.Add(book);
                Console.WriteLine($"{Name} rented '{book.Title}'.");
                return;
            }
            Console.WriteLine($"'{book.Title}' is not available.");
            return;
        }
        public void ReturnBook(Book book)
        {
            if (RentedBooks.Remove(book))
            {
                book.Status = true;
                Console.WriteLine($"{Name} returned '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"{Name} does not have '{book.Title}'.");
            }
        }
    }
}
