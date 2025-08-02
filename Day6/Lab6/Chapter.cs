using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Chapter
    {
        public string Title;
        public int Order;
        public int NoPages;

        public Chapter(string title, int order, int pages)
        {
            Title = title;
            Order = order;
            NoPages = pages; 
        }
    }
}
