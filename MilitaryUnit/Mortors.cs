using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Mortors : Weapons //can cook more specific foods and everything that a regular chef can do.
    {
        public Mortors() : base("Mortors", "fires in a team position", 60, 5700)
        {
        }
        public override void Ammo()
        {
            Console.WriteLine($"{weaponName} fires {caliber}mm ammunition");
        }
        public override void Position()                                   // designed to be overridden by derived class
        {
            Console.WriteLine($"{weaponName} {position}");
        }
        public override void Range()
        {
            Console.WriteLine($"{weaponName} can fire out to a max {range}");
        }
        public override void MagMax()
        {
            Console.WriteLine($"Users of a {base.weaponName} sytem will carry about 50 rds on team if position is static. ");
        }
    }
}
