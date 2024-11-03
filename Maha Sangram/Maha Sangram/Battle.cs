using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maha_Sangram
{
    class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Battle Over")
                {
                    Console.WriteLine("Battle Over");
                    break;
                }

                if (GetAttackResult(warrior2,warrior1) == "Battle Over")
                {
                    Console.WriteLine("Battle Over");
                    break;
                }
                   
            }
        }

        public static string GetAttackResult(Warrior warriorA,  Warrior warriorB)
        {
            double warAatckAmt = warriorA.Attack();
            double warBbloAmt = warriorB.Block();
            double warAmagAmt = warriorB.MagicCasting();

            double dmg2WarB = warAatckAmt - warBbloAmt;
            double Mdmg2WarB = warAmagAmt - warBbloAmt;

            // Clamp damage to non-negative values using Math.Max
            double actualPhysicalDamage = Math.Max(dmg2WarB, 0);
            double actualMagicDamage = Math.Max(Mdmg2WarB, 0);

            warriorB.Health -= actualPhysicalDamage;
            warriorB.Health -= actualMagicDamage;

            /*Console.WriteLine("{0} attacks {1} and deals {2} damage (Physical + Magic).",
                warriorA.Name,warriorB.Name,Tdmg);*/

            Console.WriteLine("{0} attacks {1} and deals {2} Physical damage.",
             warriorA.Name, warriorB.Name, actualPhysicalDamage);
            Console.WriteLine("{0} attacks {1} and deals {2} Magic damage.",
                warriorA.Name, warriorB.Name, actualMagicDamage);
            Console.WriteLine("{0} has {1} Health\n",
                warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorious\n",
                    warriorB.Name, warriorA.Name);
                return "Battle Over";
            }
            else
            {
                return "Fight Again";
            }
        }


    }
}
