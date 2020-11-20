using System;
using System.ComponentModel;
using System.Threading;

namespace loops_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Console.Write($"Enter number:");
            string nText = Console.ReadLine();
            int n = Int32.Parse(nText);

            // 2.
            Console.WriteLine();
            Console.WriteLine("Line");

            for (int i = 0; i < n; i++)
            {
                Console.Write("#");

            }

            Console.WriteLine();

            // 3.
            Console.WriteLine();
            Console.WriteLine("Square");

            // WRITE CODE HERE
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();


            }
            Console.WriteLine();

            // 4.
            Console.WriteLine();
            Console.WriteLine("Right triangle");

            // WRITE CODE HERE
            for (int row = 1; row <= n; row++)
            {
                int lineLength = row;

                for (int i = 0; i < lineLength; i++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            // 5.
            Console.WriteLine();
            Console.WriteLine("Parallelogram");

            // WRITE CODE HERE
            for (int i = n - 1; i >= 0; i--)
            {
                int spacesLength = i;

                for (int j = 0; j < spacesLength; j++)
                {
                    Console.Write(" ");
                }

                int lineLength = n;

                for (int j = 0; j < lineLength; j++)
                {
                    Console.Write("#");
                }


                Console.WriteLine();


            }
            Console.WriteLine();

            // 6.
            Console.WriteLine();
            Console.WriteLine("triangel");


            for (int i = 0; i < n; i++)
            {
                int spacesLength = -i + (n - 1);

                for (int j = 0; j < spacesLength; j++)
                {
                    Console.Write(" ");
                }

                int lineLength = 2 * i + 1;

                for (int j = 0; j < lineLength; j++)
                {
                    Console.Write("#");
                }


                Console.WriteLine();
            }
            Console.WriteLine();

            // 7.
            Console.WriteLine();
            Console.WriteLine("rows");

            // WRITE CODE HERE
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();

            // 8.
            Console.WriteLine();
            Console.WriteLine("columns");

            //WRITE CODE HERE
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n + 1) / 2; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 9.
            Console.WriteLine();
            Console.WriteLine("grid");

            //WRITE CODE HERE
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                //top row
                for (int j = 0; j < n; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

                int bottomRowIndex = i * 2 + 1;

                if (bottomRowIndex < n)
                {
                    //bottom row
                    for (int j = 0; j < (n + 1) / 2; j++)
                    {
                        Console.Write("# ");
                    }
                    Console.WriteLine();
                }
            }

            // 10.
            Console.WriteLine();
            Console.WriteLine("fence");
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                //top row 
                for (int j = 0; j < n / 2; j++)
                {
                    Console.Write(" #");
                }
                Console.WriteLine();

                int bottomRowIndex = i * 2 + 1;

                if (bottomRowIndex < n)
                {
                    //bottom row
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
            }
            //11
            Console.WriteLine();
            Console.WriteLine("chessboard");
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                for (int j = 0; j < (n + 1) / 2; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();

                int bottomRowIndex = i * 2 + 1;

                if (bottomRowIndex < n)
                {
                    for (int j = 0; j < n / 2; j++)
                    {
                        Console.Write(" #");
                    }
                    Console.WriteLine();
                }




            }
            //12

            Console.WriteLine();
            Console.WriteLine("slope");
            int L = 1;
            while (L < 80)
            {
                for (int i = 0; i < L; i++)
                {

                    Console.Write("#");

                }
                Console.WriteLine();
                L *= 2;
            }
            //13
            Console.WriteLine();
            Console.WriteLine("reverse slope");
            int l = 40;
            while (l > 0)
            {
                for (int i = 0; i < l; i++)
                {

                    Console.Write("#");

                }
                Console.WriteLine();
                l -= n;

            }
            //14
            Console.WriteLine();
            Console.WriteLine("");



            //PART2
            //6 
            Console.WriteLine();
            Console.WriteLine("swedish flag");
            //top
            Console.Write(" ()");
            for (int i = 0; i < 3 * n + 3; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
            //spacer
            for (int j = 0; j < n - 1; j++)
            {
                Console.Write(" ||");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("| |");
                for (int i = 0; i < 2 * n; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            //upper middle
            Console.Write(" ||");
            for (int i = 0; i < n; i++)
            {
                Console.Write("_");
            }
            Console.Write("| |");
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("|");

            //lover middle
            Console.Write(" ||");
            for (int i = 0; i < n; i++)
            {
                Console.Write("_");
            }
            Console.Write("   ");
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("|");
            // spacer
            for (int j = 0; j < n - 1; j++)
            {
                Console.Write(" ||");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("| |");
                for (int i = 0; i < 2 * n; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }


            //bottom
            Console.Write(" ||");
            for (int i = 0; i < n; i++)
            {
                Console.Write("_");
            }
            Console.Write("|_|");
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("|");

            //under 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" ||");
            }
            Console.WriteLine(@"/00\");
            Console.WriteLine(@"|00|");




            //8
            Console.WriteLine();
            Console.WriteLine("mountain");
            for (int y = 0; y < 10; y++)
            {
                int mountainStart = n - y;
                int mountainEnd = n + y + 1;

                for (int x = 0; x < 80; x++)
                {
                    if (x == mountainStart)
                    {
                        Console.Write("/");
                    }
                    else if (x == mountainEnd)
                    {
                        Console.Write(@"\");
                    }
                    else if (x > mountainStart && x < mountainEnd)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");     
                    }

                }

                Console.WriteLine();
            }
            //7
            Console.WriteLine();
            Console.WriteLine("American flag");
            //top
            Console.Write("()");
            for (int i = 0; i <4*n-2;i++)   
            {
                Console.Write("_");
            }
            Console.WriteLine();

            // top half
            for (int j = 0; j <n; j++)
            {
                bool odd = j % 2 == 0; 

                // pole
                Console.Write("||");

                // stars
                Console.BackgroundColor = ConsoleColor.DarkBlue;

                for (int i = 0; i <n; i++)
                {
                    // draw first character 
                    Console.Write(odd ? "*" : " ");

                    if (i<n-1)
                    {
                        // draw second character
                        Console.Write(odd? " ":"*");
                    }
                    
                }

                // strip
                Console.BackgroundColor = odd ? ConsoleColor.DarkRed : ConsoleColor.White;

                for (int i = 0; i <2*n-1; i++)
                {
                    Console.Write(" ");
                }

                // end
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("|");
                
            }

            // bottom half
            Console.Write("||");
            for (int j = 0; j <2*n-1; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine("|");
            //under 
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            


        }


    }
}
