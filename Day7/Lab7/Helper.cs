using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Helper
    {
        public static void Swap<T> (ref T first,ref T second)
        {
            T temp = first;
            first = second;
            second = temp; 
        }
    }
}
