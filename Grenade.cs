using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Grenade : Weapon
    {
        public Grenade()
        {
            damage = 100;
            range = 10;
        }
        public override void Attack()
        {
            Console.WriteLine("Throw a Grenade");
        }
    }
}
