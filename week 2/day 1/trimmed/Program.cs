using System;

namespace Operating_system_detection
{
    class Program
    {
        static void Main(string[] args)
        {
            string trimmed = "       gabriel       ";
            string trimedX;

            trimedX = trimmed.Trim();
            Console.WriteLine($"[{trimedX}]");

        }
    }
}
