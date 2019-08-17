using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class M4A1 : Weapons //can cook more specific foods and everything that a regular chef can do.
    {

        public M4A1() : base("M4A1", 5.56, 800)
        {
        }
        public override void Ammo()
        {
            Console.WriteLine($"{weaponName} fires {caliber}mm ammunition");
        }
        public override void Position()                                   // designed to be overridden by derived class
        {
            Console.WriteLine($"{weaponName} fires from the {position}");
        }
        public override void Range()
        {
            Console.WriteLine($"{weaponName} can fire out to a max {range}");
        }
        public override void MagMax()
        {
            Console.WriteLine($"{base.weaponName} can hold a magazine load of 30 rds.");
        }
    }
}
