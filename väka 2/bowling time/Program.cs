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
            int totalpinsknocked = pinsKnocked1stThrow + pinsKnocked2ndThrow; 
            if (pinsKnocked1stThrow ==  10)
            {
                Console.WriteLine("First roll: X ");
            }
            else
            {
                Console.WriteLine($"First roll: {pinsKnocked1stThrow}");
            }
            if (pinsKnocked1stThrow == 10)
            {
                Console.Write("");
            }
            else if (totalpinsknocked == 10 && pinsKnocked1stThrow < 10) 
            {
                Console.WriteLine("Second roll: / ");
            }
            else
            {
                Console.WriteLine($"Second roll: {pinsKnocked2ndThrow}");
            }
            Console.WriteLine($"Knocked pins: {totalpinsknocked}");
        }
    }
}
