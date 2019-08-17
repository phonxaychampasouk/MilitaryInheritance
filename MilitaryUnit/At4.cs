using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class AT4 : Weapons //can cook more specific foods and everything that a regular chef can do.
    {
        public AT4() : base("AT4", 84, 300)
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
            Console.WriteLine($"{base.weaponName} is a fire and forget weapon. Only has 1 rd.");
        }
    }
}
