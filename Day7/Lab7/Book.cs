using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Book : IRead 
    {
        public string name { get; set; }
        public int NoPages { get; set; }

        public Book()
        {
            name = "Book1";
            NoPages = 100;
        }
        public Book(string _name,int _NoPages)
        {
            name = _name;
            NoPages = _NoPages;
        }
        public void Read()
        {
            Console.WriteLine($"I Finished {name} and Read {NoPages} pages");
        }

    }
}
