namespace Lab5
{

    internal class Program
    {
        public static void DisplayRoleDescrition(Person p1)
        {
            p1.DisplayRole();
        }
        public static void DisplayDiscount(Person p1)
        {
            p1.CalcDiscount();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Try our System");

            Person p1 = new Member();
            Person l1 = new Librarian();
            Silver s = new Silver();


            DisplayDiscount(s);
            DisplayRoleDescrition(s);

            DisplayDiscount(l1);
            DisplayRoleDescrition(l1);

            DisplayDiscount(p1);
            DisplayRoleDescrition(p1);


    }
    }
}
