using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maha_Sangram
{
    class MagicWarrior : Warrior
    {
        int magicArmourChance = 0;
        CanArmour canArmour = new CanArmour();

        int energyBlastChance = 0;
        CanEBlast canEBlast = new CanEBlast();

        int invokationChnace = 0;
        CanIF canIF = new CanIF();

        public MagicWarrior(string name = "Warrior",
            double health = 0, double atcmax = 0,
             double bloMax = 0, double magmax = 0,
             int magicArmourChance = 0, int energyBlastChance = 0,
             int invokationChnace = 0)      
            : base(name, health, atcmax, bloMax, magmax)
        {
            this.magicArmourChance = magicArmourChance;
            this.energyBlastChance = energyBlastChance;
            this.invokationChnace = invokationChnace;
        }
           
        public override double Attack()
        {
            Random rnd = new Random();
            int rndBlast = rnd.Next(1, 100);
           
            if (rndBlast < this.energyBlastChance)
            {
                Console.WriteLine($"{Name}'s {canEBlast.energyBlast()}");
                return 10000;
            }
            else
            {
                return base.Attack();
            }

        }
        public override double Block()
        {
            Random rnd = new Random();
            int rndArmour = rnd.Next(1, 100);

            if (rndArmour < this.magicArmourChance)
            {
                Console.WriteLine($"{Name}'s {canArmour.magicArmour()}");
                return 10000;
            }
            else
            {
                return base.Block();
            }

        }
        public override double MagicCasting()
        {
            Random rnd = new Random();
            int rndIF = rnd.Next(1, 100);

            if (rndIF < this.invokationChnace)
            {
                Console.WriteLine($"{Name}'s {canIF.invokedForm()}");
                return 10000;
            }
            else
            {
                return base.MagicCasting();
            }

        }

        /* 5. Abilities :
                - magic Armour 
                - energy blast
                - Invoked Form   */
    }
}
