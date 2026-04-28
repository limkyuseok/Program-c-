using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Program
{
    internal class Inventory<T> : IEnumerable
    {
        private T[] list;
        private int count = 0;

        public Inventory()
        {
            list = new T[5];
        }

        public void Add(T item) 
        {
            if (count < list.Length)
            {
                list[count++] = item;
            }
            else
            {
                Console.WriteLine("Inventory is full");
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
