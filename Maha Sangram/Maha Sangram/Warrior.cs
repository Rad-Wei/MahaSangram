using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maha_Sangram
{
    internal class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AtkMax { get; set; }
        public double BloMax { get; set; }
        public double MagMax { get; set; }

        Random rnd = new Random();

        public Warrior(string name = "Warrior",
            double health = 0,
            double atkmax = 0,
            double blomax = 0,
            double magmax = 0)
        {
            Name = name;
            Health = health;
            AtkMax = atkmax;
            BloMax = blomax;
            MagMax = magmax;
               
        }

        public virtual double Attack()
        {
            return rnd.Next(1, (int)AtkMax);
        }

        public virtual double Block()
        {
            return rnd.Next(1, (int)BloMax);
        }

        public virtual double MagicCasting()
        {
            return rnd.Next(1, (int)MagMax);
        }
    }
}
