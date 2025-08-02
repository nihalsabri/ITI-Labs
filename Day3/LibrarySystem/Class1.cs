using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
     /// Lab3
    internal class Book
    {
        private string _title;
        private string _author;
        private int _pages; 
        private int _price;

        // default constructor & chain
        //Book b1 = new Book();
        public Book() : this ("ah", 800)
        {
            _title = "not-assigned";
            _author = "not-assigned";
            _pages = 120;
            _price = 200;
        }
        // parameterized constructor 
        public Book( string title, int pages) 
        {
            this._title = title;
            this._pages = pages;
            /// will be changed , to use the default values 
            _pages = 5000;
            _price = 1000;
        }
        /// over loaded contructor ( chain contructor :))
        public Book(string title,string author ,int price, int pages)
        {
            this._title = title;
            this._pages = pages;
            /// will be changed , to use the default values 
            this._pages = 5000;
            this._price = 1000;
        }
        //////////// get & set ////////////////////
        /// property get & set 
        public string title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    title = value;
                else
                    title = "not-assigned";
            }
        }
        public string author
        {
            get { return author; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    author = value;
                else
                    author = "not-assigned";
            }
        }
        /////////////// function ////// 
        public void SetPages(int pages)
        {
            if (! (pages < 10000 && pages <= 0))
                _pages = pages;
            else
                _pages = 0;
        }
        public int GetPages()
        {
            return _pages;
        }

        public void SetPrice(int price)
        {
            if (!(price < 500 && price <= 0))
                _price = price;
            else
                _price = 500;

        }
        public int GetPrice()
        {
            return _price;
        }

        ///// display function 
        public void Display()
        {
           
            Console.WriteLine($" Title = {this._title} , Author = {this._author} , Price = {GetPages()} , Price = {GetPrice()} ");
        }
    }
}
