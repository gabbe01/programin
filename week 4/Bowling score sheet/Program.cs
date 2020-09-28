using System;

namespace Bowling_score_sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFrames = 5;




            //+-----_+-----_+
            for (int i = 0; i < totalFrames; i++) 
            {
                Console.Write("+-----");
            }
            Console.WriteLine ("+");

            //| | | _| | | _|
            for (int i = 0; i < totalFrames; i++)
            {
                Console.Write("| | | ");
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
