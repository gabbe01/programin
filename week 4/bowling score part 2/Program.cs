using System;

namespace bowling_score_part_2
{
    class Program
    {
        static void Main(string[] args)
        {


            
                int totalFrames = 5;
            for (int i = 0; i < totalFrames; i++)
            {
                Console.Write("+-----");
            }
            Console.WriteLine("+");

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
