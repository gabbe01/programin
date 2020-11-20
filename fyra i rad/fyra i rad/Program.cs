using System;

namespace fyra_i_rad
{
    class Program
    {
        static void Main(string[] args) 
        {
            // players
            int currentPlayer = 1;
                




            // create board
            int boardHeight = 6;
            int boardWidth = 7;

            int[,] board = new int[boardWidth, boardHeight];

         
          

            // initialize drawing

            Console.ForegroundColor = ConsoleColor.White;

            // draw game name 

            while (true)
            {



                // draw board
                Console.Clear();


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

                //  board lines 
                for (int y = 0; y < boardHeight; y++)
                {
                    Console.Write("|");
                    for (int x = 0; x < boardWidth; x++)
                    {
                        if (board[x, y] == 0)
                        {
                            Console.Write(" O");
                        }
                        else if (board[x, y] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(" #");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (board[x, y] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" ¤");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }

                    Console.WriteLine(" |");
                }

                // line 5 
                Console.Write("|");
                for (int i = 0; i < numberOfUnderscores; i++)
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

                // ask player which column (x coordinate) to throw piece in
                Console.Write($"Enter column (player {currentPlayer}): ");
                string columnNumberText = Console.ReadLine();
                int columnNumber = Int32.Parse(columnNumberText);
                int columnX = columnNumber - 1;

                if (board[columnX,0] == 0)
                {
                    // find an empty spot by searching from the bottom up
                    int rowY = 5;

                    while (board[columnX, rowY] > 0)
                    {
                        rowY--;
                    }

                    // place the piece in the board
                    board[columnX, rowY] = currentPlayer;

                    // change the player
                    if (currentPlayer == 1)
                    {
                        currentPlayer = 2;
                    }
                    else if (currentPlayer == 2)
                    {
                        currentPlayer = 1;
                    }
                    
                        
                    

                }
            }    
        }    
    }  
}
