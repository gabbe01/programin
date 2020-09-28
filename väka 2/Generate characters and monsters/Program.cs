using System;

namespace Generate_characters_and_monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int Hp = 40;
            int Hparmy = 40;
            int str = 0;
            for (int i = 0; i < 3; i++) 
            {
                int D6 = random.Next(1, 7);
                str = str + D6;
            }
            Console.WriteLine($"Gabriel was born with only {str} strength....");

            for (int i = 0; i < 8; i++)
            {
                int D10 = random.Next(1, 11);
                Hp = Hp + D10;
            }
            Console.WriteLine($"Retronator appears from the shadow with a massive sword and a whopping {Hp} hp!");
            Console.WriteLine("Oh shit....");

            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    int D10 = random.Next(1, 11);
                    Hparmy = Hparmy + D10;
                }
            }
            Console.WriteLine($"100 of Retronators questers with {Hparmy} hp joins the battle!");
            Console.WriteLine("Oh shit....");
        }
    }
}
