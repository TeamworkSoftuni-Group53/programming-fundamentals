using System;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());

            double miles = kilometers * 1.60934;
            Console.WriteLine($"{miles:f2}");
        }
    }
}
