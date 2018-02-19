using System;

namespace InputSum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program and continuously ask the user to enter a number or "ok" to exit. 
             * Calculate the sum of all the previously entered numbers and display it on the console.*/
        
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or \"OK\" to exit.");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input) || input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("The sum of all previously entered numbers is {0}.", sum);
        }
    }
}