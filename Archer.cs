using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Archer : Soldier
    {
        public Archer()
        {
            health = 75;
            defense = 0;
        }
        public override void Attack()
        {
            Console.WriteLine("Archer Attack\n");
        }

    }
}
