using System;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive a floating number from the console for our kilometers.
            double kilometre = double.Parse(Console.ReadLine());

            //We convert our kilometers to miles.
            double miles = kilometre * 1.60934;

            //We print the result.
            Console.WriteLine($"{miles:f2}");
        }
    }
}
