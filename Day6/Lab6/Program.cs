namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Our Library Management");

            Library library1 = new Library ( 1, "library1" );
            Library library2 = new Library ( 2, "library2" );

            Book book1 = new Book("book1", "author1", 1100,true);
            Book book2 = new Book("book2", "author2", 1200,false);
            Book book3 = new Book("book3", "author3", 1300,true);

            Person person1 = new Person(1,"User");
            Person person2 = new Person(2, "User2");
            Person person3 = new Person(3, "Librarian");

            Librarian librarian1 = new Librarian();
            library1.AddBook(book1);
            book1.DisplayBookInfo();
            library1.AddPerson(person1);
            library1.AddPerson(person2);
            
            library1.AddBook(book2);
            library1.AddBook(book3);

            library1.DisplayPerson();

            librarian1.DisplayBookStatus(book1);
            librarian1.DisplayBookStatus(book2);
            librarian1.DisplayBookStatus(book3);
            librarian1.ChangeBookStatus(book1);
            librarian1.DisplayBookStatus(book1);


            library2.AddBook(book2);
            library2.AddBook(book3);
            library2.AddPerson(person3);

            library2.RemoveBook(book3);

            library2.DisplayBook(book2);
            library2.DisplayBook(book2);






        }
    }
}
