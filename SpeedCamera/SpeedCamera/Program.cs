using System;

namespace SpeedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit (in mph).");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How fast is the car moving? (in mph)");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if(carSpeed <= speedLimit)
                Console.WriteLine("You're ok.");
            else
            {
                var demerit = (carSpeed - speedLimit) / 5;
                if(demerit <= 12)
                    Console.WriteLine("You have " + demerit + " demerit points.");
                else
                    Console.WriteLine("You have " + demerit + " demerit points." + " Your license has been suspended.");
            }
            Console.Read();
        }
    }
}