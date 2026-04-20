using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Guard : Soldier
    {
        public Guard()
        {
            health = 100;
            defense = 1;
        }
        public override void Attack()
        {
            Console.WriteLine("Guard Attack\n");
        }
    }
}
