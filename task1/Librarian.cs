using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Librarian
    {
        public string Name { get; set; }
        public Librarian(string name)
        {
            Name = name;
        }
        public void DisplayBooks(Library library)
        {
            Console.WriteLine($"Books in the library:");
            foreach (var book in library.Books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
