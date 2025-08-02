using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public Address(string street, string city)
        {
            Street = street;
            City = city;
        }
    }

    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary;
        public Address address;
        public string[] skills;



        // construcotor 
        public Employee() :this(1,"Ni",8000, "str5", "berlin")
        {
//
        }
        public Employee(int id, string name, int sal, string str, string city)
        {
            ID = id;
            Name = name;
            Salary = sal;

            skills = new string[2] { "reading", "drawing" };
            address = new Address(str, city);
        }

        public Employee Clone()
        {
            Employee emb = new Employee();
            emb.ID = ID;
            emb.Name = Name;
            emb.Salary = Salary;
            emb.skills = skills;
            emb.address = address;
            return emb;
        }

        public Employee DeepClone()
        {
            Employee emb = new Employee();
            emb.ID = ID;
            emb.Name = Name;
            emb.Salary = Salary;

            emb.skills = new string[2];
            for (int i = 0; i < 2; i++)
            {
                emb.skills[i] = emb.skills[i];
            }
            emb.address = new Address(this.address.Street, this.address.City);


            return emb;
        }
        public override string ToString()
        {
            return $"ID : {ID} , name : {Name} , salary :{Salary}, skills: {skills[0]}{skills[1]}, address:{address.Street}{address.City} ,";
        }


    }
}