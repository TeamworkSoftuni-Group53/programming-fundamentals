using System;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are receiving a floating number from the Console for our kilometers
            double kilometers = double.Parse(Console.ReadLine());

            //We are converting our kilometers into miles
            double miles = kilometers * 1.60934;

            //We are printing the result
            Console.WriteLine($"{miles:f2}");
        }
    }
}
