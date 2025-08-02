using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Librarian
    {
        //association 
        public string Name;
        public Librarian()
        {
            Name = "Loyal Employee";
        }
        public void DisplayBookStatus(Book b)
        {
            if (b.isBorrowed)
            {
                Console.WriteLine($"Not Available");
            }
            else
            {
                Console.WriteLine($"Available");
            }
        }
        public void ChangeBookStatus(Book b)
        {
            Console.WriteLine($" status changed , {!b.isBorrowed}");
            DisplayBookStatus(b);
        }
    }
}
