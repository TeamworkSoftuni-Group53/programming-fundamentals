using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            // We receive a name of product.
            string name = Console.ReadLine();

            //In the next three lines we receive amount, energy content and sugar content as an integers.
            int amount = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            //In the next two lines we calculate the energy and sugar content.
            double energySum = (double)amount * energyContent / 100;
            double sugarSum = (double)amount * sugarContent / 100;

            //We print the amount of the product and its name!
            Console.WriteLine($"{amount}ml {name}:");

            //We print the total energy and sugar content.
            Console.WriteLine($"{energySum}kcal, {sugarSum}g sugars");
        }
    }
}
