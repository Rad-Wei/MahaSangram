namespace Maha_Sangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Story story = new Story();
            story.PrintWithDelay(3);

            MagicWarrior Arjun = new MagicWarrior("Arjun",120000,1000,200,1500,35,50,80);
            MagicWarrior Raavan = new MagicWarrior("Raavan", 100000, 1200, 150, 1000,50,45,25);

            Weapon weapon = new Weapon();
            string randomWeaponA = weapon.GetRandomWeapon();
            string randomWeaponR = weapon.GetRandomWeapon();
            Console.WriteLine("Arjun got a {0}.\nRaavan got a {1}.\n"
                , randomWeaponA, randomWeaponR);


            Battle.StartFight(Arjun, Raavan);     
        }

        /* 
             A dialogue 
            B dialogue 
            A equips a random weapon 
            B equips a random weapon 
             A attacts B 
            B attacks A 
            1. random damage with a caping of (max attack bar)
            2. max block bar
            3. health bar
            4. magic bar
            5. Abilities :
            - magic Armour 
            - energy blast
            - Invoked Form 
            */
    }
}
