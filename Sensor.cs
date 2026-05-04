using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Sensor
    {
        public void Detect(Product product)
        {
            Console.WriteLine("It has been Detected");

            product.Describe();
        }
    }
}
