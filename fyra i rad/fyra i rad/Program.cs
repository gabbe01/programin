using System;

namespace fyra_i_rad
{
    class Program
    {
        static void Main(string[] args)
        { 
            int boardHeight = 6;
            int boardWidth = 7;

            // line 1
            Console.Write(" ");
            for (int i = 1; i <= boardWidth; i++)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();

            // line 2
            Console.Write(" ");
            int numberOfUnderscores = 2 * boardWidth + 1;
            for (int i = 0; i < numberOfUnderscores; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();

            // line 3
            Console.Write("|");
            for (int i = 0; i < numberOfUnderscores; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");


            // line 4
            for (int i = 0; i < boardHeight; i++)
            {
                Console.Write("|");
                for (int j = 0; j < boardWidth; j++)
                {
                    Console.Write(" O");
                }
                Console.WriteLine(" |");
            }


            // line 5 
            Console.Write("|");
            for (int i = 0; i <numberOfUnderscores; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("|");

            //line 6
            Console.Write("|");
            for (int i = 0; i < numberOfUnderscores; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("|");


            // line 7
            Console.Write("\\");
            for (int i = 0; i < numberOfUnderscores; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("/");




        }   
    }
}
