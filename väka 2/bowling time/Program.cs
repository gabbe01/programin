using System;

namespace bowling_time

{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int pinsKnocked1stThrow = random.Next(0, 11);
            int pinsKnocked2ndThrow = random.Next(0, 11 - pinsKnocked1stThrow);

            Console.WriteLine($"First roll: {pinsKnocked1stThrow}");
            Console.WriteLine($"Second roll: {pinsKnocked2ndThrow}");
        }
    }
}
