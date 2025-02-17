using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }
    }
}
