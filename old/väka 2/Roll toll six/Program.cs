using System;

namespace Roll_toll_six
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; 
            var random = new Random();
            int diceTrow = random.Next(1, 7);
            if (diceTrow == 6)
            {
                Console.WriteLine($"The player rolls: {diceTrow}");
                sum = sum + diceTrow;
            }

            while (diceTrow < 6)
            {
                diceTrow = random.Next(1, 7);
                Console.WriteLine($"The player rolls: {diceTrow}");
                sum = sum + diceTrow;
               
            }
            Console.WriteLine($"Total score: {sum}");













        }
    }
}       
