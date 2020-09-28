using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Threading;

namespace The_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var streamPositions = new List<int> { };
            var streamColors = new List<ConsoleColor> { };

            var symbols = "10";
            var possibleColors = new List<ConsoleColor> { ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.White, };  

            for (int i = 0; i < 80; i++)
            {
                streamPositions.Add(random.Next(0, Console.BufferWidth));

                int randomColorIndex = random.Next(possibleColors.Count);
                var newStreamColor = possibleColors[randomColorIndex];
                streamColors.Add(newStreamColor);
            }   
            
            while (true)
            {
                for (int x = 0; x < Console.BufferWidth; x++)
                {
                    int streamIndex = streamPositions.IndexOf(x);

                    if (streamIndex > -1)
                    {
                        Console.ForegroundColor = streamColors[streamIndex];
                        Console.Write(symbols[random.Next(symbols.Length)]);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                                        
                }
                Thread.Sleep(100);
                Console.WriteLine(); 

                if (random.Next(3) == 0)
                {
                   int removindex = random.Next(streamPositions.Count);
                    streamPositions.RemoveAt(removindex);
                    streamColors.RemoveAt(removindex);
                }
                    
                if (random.Next(3) == 0)
                {
                    streamPositions.Add(random.Next(0, Console.BufferWidth));
                    int randomColorIndex = random.Next(possibleColors.Count);
                    var newStreamColor = possibleColors[randomColorIndex];
                    streamColors.Add(newStreamColor);
                }
            }
        }
    }
}
 