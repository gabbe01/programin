using System;
using System.Xml.Schema;

namespace Hit_accuracy
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int totalShots = random.Next(10, 21);
            int hits = random.Next(0, totalShots+1);
            Console.WriteLine($"Total shots: {totalShots}");
            Console.WriteLine($"Hits made: {hits}");
            

            double hitAccuracy = (double)hits / (double)totalShots;
            double hitAccuracyPercentage = (100 * hitAccuracy);
            Console.WriteLine($"Hit accuracy: {hitAccuracyPercentage}%");

        }
    }
}
