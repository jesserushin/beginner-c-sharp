using System;

namespace ImageDimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the width of the image.");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height of the image.");
            var height = Convert.ToInt32(Console.ReadLine());

            if(width > height)
                Console.WriteLine("Your image is landscape.");
            else if(width < height)
                Console.WriteLine("Your image is portrait.");
            else
                Console.WriteLine("Your image is a square!");
            Console.Read();
        }
    }
}