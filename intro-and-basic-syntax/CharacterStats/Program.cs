using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string healthBar = "|" + new string('|', currentHealth) + new string('.', maxHealth - currentHealth) + "|";
            string energyBar = "|" + new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy) + "|";

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {healthBar}");
            Console.WriteLine($"Energy: {energyBar}");
        }
    }
}
