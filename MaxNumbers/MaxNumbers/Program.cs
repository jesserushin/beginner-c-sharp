using System;

namespace MaxNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number.");
            var firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number.");
            var secondNum = Convert.ToInt32(Console.ReadLine());

            if(firstNum > secondNum)
                Console.WriteLine(firstNum + " is the maximum of the two numbers.");
            else if (firstNum < secondNum)
                Console.WriteLine(secondNum + " is the maximum of the two numbers.");
            else
                Console.WriteLine("These two numbers are equal. Please enter a new set of numbers.");
            Console.Read();
        }
    }
}