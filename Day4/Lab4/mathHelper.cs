using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal static class mathHelper
    {
        //int x; static int y;
        //public void Myfunction(int num)
        //{
        //    x = num;
        //    y = num;

        //}
        public static int add(int operand1, int operand2)
        {
            //x = operand1;
            //y = operand1;
            return operand1 + operand2;

        }
        public static int sub(int operand1, int operand2)
        {
            return operand1 - operand2;
        }
        public static int mul(int operand1, int operand2)
        {
            return operand1 * operand2;
        }
        public static int div(int operand1, int operand2,out int res)
        {
            if (operand2 != 0 && operand1 > 0 && operand2 > 0)
            {
                res = operand1 / operand2;
                return res;
            }
            else
                res = 0;
                return 0;
        }



    
}
}
