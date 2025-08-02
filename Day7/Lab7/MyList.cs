using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    // replace double / object or any with <T> to make it generic
    internal class MyList<T>
    {
        public T[] items { get; set; }
        int count;
        int size;
        int ExtendSize;
        public MyList(int capacity , int extendSize)
        {

            size = capacity;
            items = new T[capacity];
            count = 0;
            ExtendSize = extendSize;
        }
        public void Add(T item)
        {
            if (count < size) {
                items[count++] = item;
            } else
            {
                Extend();
                items[count++] = item;

            }
        }

        public void Display ()

        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }


        public void Extend ()
        {
            size += ExtendSize;
            T[] temp = new T[size];

            for(int i = 0; i < count;i++)
            {
                 temp[i]= items[i];
            }
            items = temp;


        }

    }
}
