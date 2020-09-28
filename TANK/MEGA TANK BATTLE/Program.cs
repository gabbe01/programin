using System;

namespace MEGA_TANK_BATTLE
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int tankDistance = random.Next(40, 71);
            int width = 80;
            
            Console.WriteLine("DANGER! A tank is approaching our position. Your artilery unit is our only hope!");
            Console.WriteLine("");
            Console.WriteLine("Here is the map of the battlefield:");
            
            Console.ReadKey();
        }    
    }
}
