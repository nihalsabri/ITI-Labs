using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Silver : Member
    {
        public Silver():base()
        {
            
        }
        public override void CalcDiscount()
        {
            Console.WriteLine("10");
            //return 10;

        }

    }
}
