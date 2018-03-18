using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double energySum = (double)amount * energyContent / 100;
            double sugarSum = (double)amount * sugarContent / 100;

            Console.WriteLine($"{amount}ml {name}:");
            Console.WriteLine($"{energySum}kcal, {sugarSum}g sugars");
        }
    }
}
