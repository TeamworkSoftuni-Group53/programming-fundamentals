//CONFIRMED from ash-rain
using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
			// We get an input of the height and width of a rectangle
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
			// We calculate the area of the rectangle, using the input data
            double rectangleArea = width * height;
			// We print the result, formatted to up to 2 floating point numbers
            Console.WriteLine($"{rectangleArea:f2}");
        }
    }
}