using System;

namespace ValidInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10.");
            var input = Convert.ToInt32(Console.ReadLine());

            if(input >= 1 && input <= 10)
                Console.WriteLine("Valid input.");
            else
                Console.WriteLine("Invalid input.");
            Console.WriteLine("Press any key.");
            Console.Read();
        }
    }
}