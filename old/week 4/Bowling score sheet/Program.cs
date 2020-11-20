using System;
using System.Security.Cryptography.X509Certificates;

namespace Bowling_score_sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFrames = 10;
            var random = new Random();



            //+-----_+-----_+
            for (int i = 0; i < totalFrames; i++)
            {
                Console.Write("+-----");
            }
            Console.WriteLine("+");

            //| | | _| | | _|
            for (int i = 0; i < totalFrames; i++)
            {
                // Bowling frame simulation code.
                int pinsKnocked1stThrow = random.Next(0, 11);
                int pinsKnocked2ndThrow = random.Next(0, 11 - pinsKnocked1stThrow);
                int totalpinsknocked = pinsKnocked1stThrow + pinsKnocked2ndThrow;
                
                string roll1Text = $"{pinsKnocked1stThrow}";
                string roll2Text = $"{pinsKnocked2ndThrow}";

                // Check if the frame is a strike.
                if (pinsKnocked1stThrow == 10)
                {
                    // Change the text to show a strike.
                    roll1Text = $"X";
                    roll2Text = $" ";
                }
                // Check if frame was a spare.
                else if (totalpinsknocked == 10)
                {
                    // Change text to show a spare.
                    roll2Text = $"/";
                }
                 
                // Check if first throw was a 0.
                if (pinsKnocked1stThrow == 0)
                {
                    roll1Text = $"-";
                }


                // Check if second throw was a 0.
                if (pinsKnocked2ndThrow == 0)
                {
                    roll2Text = $"-";
                }



                // Write the result of frame.
                Console.Write($"| |{roll1Text}|{roll2Text}");
            }
            Console.WriteLine("|");


            //| ----_| ----_|
            for (int i = 0; i < totalFrames; i++)
            {
                Console.Write("| ----");
            }
            Console.WriteLine("|");


            //|     _|     _|
            for (int i = 0; i < totalFrames; i++)
            {
                Console.Write("|     ");
            }
            Console.WriteLine("|");

            //+-----_+-----_+
            for (int i = 0; i < totalFrames; i++)
            {
                Console.Write("+-----");
            }
            Console.WriteLine("+");
        }
    }
}
