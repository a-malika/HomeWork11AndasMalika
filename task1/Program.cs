using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();
            Librarian librarian = new Librarian("Anna");
            Reader reader = new Reader("Esma");

            library.AddBook(new Book("C# in Depth", "Jon Skeet", "9781617294532"));
            library.AddBook(new Book("Clean Code", "Robert C. Martin", "9780132350884"));
            library.AddBook(new Book("The Pragmatic Programmer", "Andrew Hunt", "9780135957059"));
            library.AddBook(new Book("The Pragmatic Programmer", "Andrew Hunt", "9780135957059"));

            librarian.DisplayBooks(library);

            var bookToSearch = library.FindBookByTitle("code");
            if (bookToSearch != null)
            {
                Console.WriteLine($"Found book: {bookToSearch}");
            }

            reader.RentBook(library.Books[1]);
            librarian.DisplayBooks(library);

            reader.ReturnBook(library.Books[1]);
            librarian.DisplayBooks(library);

            reader.RentBook(library.Books[0]);
            reader.RentBook(library.Books[1]);
            reader.RentBook(library.Books[2]);
            reader.RentBook(library.Books[3]);
        }
    }
}
