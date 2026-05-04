using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal abstract class Product
    {
        protected string menuel;
        protected int price;

        public void Describe()
        {
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Menuel : " + menuel);

            Console.WriteLine();
        }
    }
}
