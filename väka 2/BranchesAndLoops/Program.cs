using System;


namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            
            sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                } 
                



            }
            Console.WriteLine($"the sum is {sum}"); 



        }       
    }
}
