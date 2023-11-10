using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThLibrary
{
    internal class Bok
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Isbn { get; set; }
        public Bok(string title, string author, int isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Title: {Title} Author: {Author} Isbn: {Isbn}");
        }
    }
}
