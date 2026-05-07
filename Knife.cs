using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Knife : Weapon
    {
        public Knife()
        {
            range = 1;
            damage = 10;
        }

        public override void Attack()
        {
            Console.WriteLine("Knife stab");
        }
    }
}
