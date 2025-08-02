using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Library
    {
        public int ID;
        public string Name;
        List<Book> books;
        List<Person> people;


        public Library(int id, string name)
        {
            ID = id;
            Name = name;
            // aggregation "" empty List 
            books = new List<Book>();
            people = new List<Person>();

            
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public void DisplayBook(Book book)
        {
            foreach (Book item in books)
            {
                Console.WriteLine($"Book Name = {item.BookName} , Author ={item.Author}, No. of Pages = {item.PagesNo} ");
            }
        }

        public void AddPerson(Person person)
        {
            people.Add(person);
        }
        public void RemovePerson(Person person)
        {
            people.Remove(person);
        }
        public void DisplayPerson()
        {
            foreach (Person item in people)
            {
                Console.WriteLine($" PersonID = {item.PersonID} , Its Role ={item.Role}");
            }
        }
    }
    }


