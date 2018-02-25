using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
        /* Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
         * If the user guesses the number, display “You won"; otherwise, display “You lost". 
         * (To make sure the program is behaving correctly, you can display the secret number on the console first.)*/

            var random = new Random().Next(1, 10);
            Console.WriteLine("The secret number is: " + random);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number == random)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lost.");
        }
    }
}