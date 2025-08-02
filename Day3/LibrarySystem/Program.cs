namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Books' Shelf :) ");

        Book book1 = new Book();
            book1.Display();
            Book book2 = new Book("HopeRoad", "AH",400,450);
            book2.Display();

        }
    }
}
