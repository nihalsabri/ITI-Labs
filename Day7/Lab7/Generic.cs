using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Generic<T>
    {
        private T data;
        public T value
        {

            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
       //Generic<T> void GDisplay(){
       //     Console.WriteLine($"{this.value}");
       // } 

    }
}
