using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Status { get; set; }
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Status = true;
        }
        public override string ToString()
        {
            return $"{Title} by {Author} (ISBN: {ISBN}) - {(Status ? "Available" : "Rented")}";
        }
    }
}
