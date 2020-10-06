using System;

namespace MEGA_TANK_BATTLE
{
    class Program
    {
       

        static void Main(string[] args)
        {   
            var random = new Random();
            int tankDistance = random.Next(40, 70);
            int Width = 80; 
            Console.WriteLine("DANGER! An AT-AT is approaching our position. help us obi wan kenobi Your our only hope!");
            Console.WriteLine();
            Console.WriteLine("What is your name, commander?");
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Here is the map of the battlefield:");
            Console.WriteLine();

           
            Console.Write($"_/");

            
            for (int i = 0; i < tankDistance; i++)
            {
                Console.Write($"_");
            }

           
            Console.Write($"T");

           
            int restOfGrondDistance = 80 - 1 - 2 - tankDistance;
            for (int i = 0; i < restOfGrondDistance; i++)
            {
                Console.Write($"_");
            }
            Console.WriteLine();
            Console.WriteLine();


            int shells = 5;
            for (int shotNumber = 0; shotNumber < 5; shotNumber++)
            {


                Console.WriteLine($"Aim your shot,{name}");
                Console.Write($"Enter distance: ");
                string shotDistanceText = Console.ReadLine();
                int shotDistance = Int32.Parse(shotDistanceText);

                // Draw explosion
                // 1. Write enough spaces to reach explosion.
                
                for (int i = 0; i < 2 + shotDistance; i++)
                {
                    Console.Write(" ");
                }

                // 2. Write explosion character.
                Console.WriteLine("*");


                // Output result of shot.
                if (shotDistance < tankDistance)
                {
                    Console.WriteLine("your shot was too short.");
                }
                else if (shotDistance > tankDistance)
                {
                    Console.WriteLine("your shot was too long.");
                }
                else
                {
                    Console.WriteLine("EXPLOSION VICTORY!!");
                    break;
                }
               
                shells--;

                Console.WriteLine($"you have {shells} shells left.");
                



                Console.WriteLine();
            }


            if(shells == 0)
            {
                Console.WriteLine("GAME OVER NOOB");
            }
            






        }
    }
}
