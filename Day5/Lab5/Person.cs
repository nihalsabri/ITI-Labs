using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal abstract class Person
    {
        //attributes
        public string name;
        protected int age;
        // constructor 
        public Person()
        {
            name = "person_test";
            age = 20;
            Console.WriteLine("default person constructor");
        }

        public Person( string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("paramtarized person constructor");

        }
        // functions 
        public virtual void DisplayRole()
        {
            Console.WriteLine("Person Role");
        }
        public virtual void CalcDiscount()
        {
            Console.WriteLine("0");

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"name = {name} , age = {age}");
        }

        public void DisplayRoleDescrition()
        {

        }
        public void DisplayDiscount()
        {

        }





    }
}
