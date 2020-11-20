using System;
using System.IO.MemoryMappedFiles;
using System.Threading;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = { "Mon", "tue", "wed", "thu", "fri", "sat", "sun" };

            Console.WriteLine(String.Join(", ", week));



            string[] month = new string[30];
            int dayOfTheWeekIndex = 6;

            for (int i = 0; i < 30; i++)
            {
                month[i] = $"{i + 1}: {week[dayOfTheWeekIndex]}";
                dayOfTheWeekIndex++;
                if (dayOfTheWeekIndex == 7)
                {
                    dayOfTheWeekIndex = 0;
                }
            }
            Console.WriteLine(string.Join(", ", month));
            Console.WriteLine();


            var random = new Random();
            double[] numbers = new double[random.Next(5, 11)];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 11);
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();


            var matrix = new int[random.Next(2, 6), random.Next(2, 6)];
            int height = matrix.GetLength(1);
            int width = matrix.GetLength(0);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    matrix[x, y] = random.Next(0, 10);
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(matrix[x, y]);
                }

                Console.WriteLine();
            }

        }
    }
}
