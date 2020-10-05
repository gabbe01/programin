using System;

namespace MEGA_TANK_BATTLE
{
    class Program
    {
        private static int width;

        static void Main(string[] args)
        {
            var random = new Random();
            int tankDistance = random.Next(40, 70);
            
            Console.WriteLine("DANGER! A tank is approaching our position. help us obi wan kenobi Your our only hope!");
            Console.WriteLine();
            Console.WriteLine("Here is the map of the battlefield:");
            Console.WriteLine();

            // Draw the artillery (2 characters)
            Console.Write($"_/");

            // Draw the ground between artillery to tank (tankDistance characters)
            for (int i = 0; i < tankDistance; i++)
            {
                Console.Write($"_");
            }

            // Draw the tank (1 character)
            Console.Write($"T");

            // Draw the rest of the ground (restOfGrondDistance characters ... so that total is 80 characters)
            int restOfGrondDistance = 80 - 1 - 2 - tankDistance;
            for (int i = 0; i < restOfGrondDistance; i++)
            {
                Console.Write($"_");
            }
            Console.WriteLine();





        }
    }
}
