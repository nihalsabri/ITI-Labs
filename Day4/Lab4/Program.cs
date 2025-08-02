using System.Runtime.InteropServices;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mathHelper helper = new mathHelper();
            
            Console.WriteLine("Try to use mathHelper");

            /// mathHelper Helper = new mathHelper(); /// remove "static" from the class
            Console.WriteLine(mathHelper.add(4, 5));
            Console.WriteLine(mathHelper.mul(4, 5));
            Console.WriteLine(mathHelper.div(8, 2, out int res));
            ///// 2nd task : 
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Fraction f3 = new Fraction();
            f3 = f1 + f2;
            Console.WriteLine(f3);
            f3 = f1 / f2;
            Console.WriteLine(f3);
            f3 = f1 - f2;
            Console.WriteLine(f3);
            f3 = f1 * f2;
            Console.WriteLine(f3);

            /////// shallow and deep copy 
           
            Employee emb = new Employee(1,"ah",3000,"str","city");
            Employee emb1 = emb.Clone();
            Employee emb2 = emb;
            emb2.skills[0] = "test";
            Console.WriteLine(emb1);
            Console.WriteLine(emb2);

            Employee emb3 = emb.DeepClone();
            emb3.ID = 3;
            emb3.Name = "ah2";
            emb3.skills[0] = "MusicListen";
             //emb3.address = (City,h);

            emb3.address = new Address ("str3","city3");
            Console.WriteLine(emb3);


        }




    }
}
