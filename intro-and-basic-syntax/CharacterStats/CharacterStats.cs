//CONFIRMED from vertagen
using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive the name of our character.
            string name = Console.ReadLine();

            //In the next four lines we receive the current health, maximum health, current energy and maximum energy.
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            //In then next two lines we are creating the health and energy bar of our character.
            string healthBar = "|" + new string('|', currentHealth) + new string('.', maximumHealth - currentHealth) + "|";
            string energyBar = "|" + new string('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy) + "|";

            //in then text three lines we print the name, health and energy bar of our character.
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {healthBar}");
            Console.WriteLine($"Energy: {energyBar}");
        }
    }
}
