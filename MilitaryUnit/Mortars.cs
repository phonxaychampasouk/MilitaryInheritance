using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class App
    {
        public void WeaponRun()
        {
            var m4A1 = new M4A1();  // will be able to refer to mammal
            var mortors = new Mortors();
            var aT4 = new AT4();

            var weapons = new List<Weapons>() { m4A1, mortors, aT4 }; // or pass them into a list of mammals

            foreach (var weapon in weapons) // var is taking from mammal list
            {
                Capabilities(weapon);
            }

            //DoMammalStuff(bat);
            //DoMammalStuff(human);
            //DoMammalStuff(cow);
        }
        private void Capabilities(Weapons weapon) // taking in mammal and do something special
        {
            weapon.Ammo();
            weapon.Position();
            weapon.Range();
            Console.WriteLine();
        }
    }
}
