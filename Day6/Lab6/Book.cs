using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab6
{
    public class Book
    {
        public string BookName;
        public string Author;
        public int PagesNo;
        List<Chapter> chapters;
        public bool isBorrowed;// false
        // composition filled List
        public Book(string bookname,string author,int pages, bool Borrowed)
        {
            BookName = bookname;
            Author = author;
            PagesNo = pages;
             isBorrowed= Borrowed;

            chapters = new List<Chapter>() { new Chapter("ch1", 1, 22), new Chapter("ch2", 2, 40) };

        }

        public void DisplayBookInfo ( )
        {
            Console.WriteLine($"Book Name ={BookName} , Author ={Author}, No. of Pages = {PagesNo}");

            foreach (Chapter item in chapters)
            {
                Console.WriteLine($" Name = {item.Title}, Author ={item.Order}, No. of Pages = {item.NoPages} ,");
            }
        }

    }
}
