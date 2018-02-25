using System;

namespace NumberSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program and ask the user to enter a series of numbers separated by comma. 
             * Find the maximum of the numbers and display it on the console. 
             * For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.*/

            Console.WriteLine("Enter a series of numbers, separated by a comma.");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var maxNum = Convert.ToInt32(numbers[0]);
            foreach (var item in numbers)
            {
                var number = Convert.ToInt32(item);
                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            Console.WriteLine("The max number is: " + maxNum);
        }
    }
}