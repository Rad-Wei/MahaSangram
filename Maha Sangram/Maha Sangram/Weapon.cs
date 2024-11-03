using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maha_Sangram
{
    internal class Weapon
    {
       private static readonly string[] Weapons = { "Axe", "Sword", "Polearm", "Bow", "Claymore", "Catalyst" };
        private Random random;

        public Weapon()
        {
            random = new Random();
        }

        public string GetRandomWeapon()
        {
            int randomIndex = random.Next(Weapons.Length);
            return Weapons[randomIndex];
        }
    }
}
