using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Librarian :Person
    {
        public int id;
        public int salary;
        //parameterless
        public Librarian()
        {
            id = 1;
            salary = 20000;
            Console.WriteLine("default Librarian constructor");
        }
        // parameterized
        public Librarian(int id,int salary) :base("NS",25)
        {
            this.id = id;
            this.salary = salary;
            Console.WriteLine("paramtarized Librarian constructor");

        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"id = {id} , salary={salary}");
        }
        public override void DisplayRole()
        {
            Console.WriteLine(" Librarian Role");
        }
        public override void CalcDiscount()
        {
            Console.WriteLine(30);
            //return 30;
        }


    }
}
