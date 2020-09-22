using System;

namespace Dice_throws
{
    class Program
    {
        static void Main(string[] args)
        {   var random = new Random(); 
            int diceThrow = random.Next(1, 7);
            int diceThrow2 = random.Next(1, 7);
            int diceThrow3 = random.Next(1, 7);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"first dice throw is:{diceThrow}");
            Console.WriteLine($"second dice throw is:{diceThrow2}");
            Console.WriteLine($"third dice throw is:{diceThrow3}");
            int totalsum = diceThrow + diceThrow2 + diceThrow3;
            Console.WriteLine($"SCORE:{totalsum}"); 
            
        }
    }
}
