using System;

namespace DebitNumber
{
    class Program
    {
		static void Main()
		{
                     //we get 4 integer numbers that we read from the console
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

                    //we print them in 4-digit debit card format
            Console.WriteLine($"{number1:D4} {number2:D4} {number3:D4} {number4:D4}");
		}
    }
}
