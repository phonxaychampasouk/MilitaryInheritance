//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MilitaryUnit
//{

//        abstract class Weapons
//        {
//            protected readonly string position = "All positions"; // protecgt can only be viewed in base and derived class
//            protected readonly string weaponName; // only can read it.
//            protected readonly double caliber; // can only be used twice
//            protected readonly int range;

//            protected Weapons(string weaponName, double caliber, int range) // Mammal is the constructor
//            {
//                this.weaponName = weaponName;
//                this.caliber = caliber;
//                this.range = range;

//            }
//            protected Weapons(string weaponName, string position, int range, double caliber)// set as class scope this.
//            {
//                this.weaponName = weaponName;
//                this.position = position;
//                this.range = range;
//                this.caliber = caliber;

//            }
//            public virtual void Ammo()
//            {
//                Console.WriteLine($"{weaponName} fires {caliber}mm ammunition");
//            }
//            public virtual void Position()                                   // designed to be overridden by derived class
//            {
//                Console.WriteLine($"{weaponName} fires from the {position}");
//            }
//            public virtual void Range()
//            {
//                Console.WriteLine($"{weaponName} can fire out to a max {range}");
//            }
//            public abstract void MagMax();


//        }
//    }




//}
