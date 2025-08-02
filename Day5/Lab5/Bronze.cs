using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Bronze : Member
    {
        public Bronze():base()
        {
            
        }
        public override void CalcDiscount()
        {
            Console.WriteLine(5);
            //return 5;

        }
    }
}
