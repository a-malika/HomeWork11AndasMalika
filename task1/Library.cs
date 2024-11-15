using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Added '{book.Title}' to the library.");
        }
        public Book? FindBookByTitle(string title)
        {
            return Books.FirstOrDefault(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }
        public Book? FindBookByAuthor(string author)
        {
            return Books.FirstOrDefault(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase));
        }
    }
}
