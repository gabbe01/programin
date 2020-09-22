using System;
using System.Net.Sockets;

namespace Regenerate 
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int warriorhp = random.Next(1, 101);
            Console.WriteLine($"Warrior HP:{warriorhp}");
            Console.WriteLine($"Regenerate spell is cast!");

            while (warriorhp < 50)
            {
                warriorhp = warriorhp + 10;
                Console.WriteLine($"warrior hp:{warriorhp}");
            }

            Console.WriteLine($"Regenerate spell is complete");

            



        }
    }
}
