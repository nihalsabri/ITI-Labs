using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Member :Person
    {
        public string membershipType;
        public Member()
        {
            membershipType = "Gold";
            Console.WriteLine("default member constructor");
        }
        public Member(string type) : base("ah",20)
        {
            membershipType = type;
            Console.WriteLine("paramtarized Member constructor");

        }
        // function 1/ display (hide)
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Membership Type = {membershipType}");
        }
        //function 2/ role description override 
        public override void DisplayRole()
        {
            Console.WriteLine("Member Role");
        }

        public override void CalcDiscount()
        {
            Console.WriteLine("Gold 20%,Silver10%,Bronze 5%");

            //return 100;

        }
    }
}
