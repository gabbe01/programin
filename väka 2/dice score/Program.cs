using System;

namespace dice_score
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int diceTrow = random.Next(1, 7);
            int diceTrow2 = random.Next(1, 7);
            int diceTrow3 = random.Next(1, 7); 
            int sum = diceTrow + diceTrow2 + diceTrow3 *3;
            int sum2 = sum * 2;
            Console.WriteLine("press enter to ROLL....");
            Console.ReadKey(true);
            Console.WriteLine($"first ROLL is: {diceTrow}");
            Console.ReadKey(true);
            Console.WriteLine($"second ROLL is: {diceTrow2}");
            Console.ReadKey(true);
            Console.WriteLine($"third ROLL is: {diceTrow3}");
            
            Console.WriteLine("press enter for score");
            Console.ReadKey(true);
            Console.WriteLine($"total score is: {sum2}");
            










        }
    }
}
