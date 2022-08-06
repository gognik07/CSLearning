using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int minN = 1;
            int maxN = 28;
            Random random = new Random();
            int n = random.Next(minN, maxN);
            Console.WriteLine($"N = {n}");
            int minMultiple = 100;
            int maxMultiple = 1000;
            int resultMultipleN = n;

            while(resultMultipleN < maxMultiple)
            {
                if (resultMultipleN > minMultiple)
                {
                    Console.WriteLine(resultMultipleN);
                }
                resultMultipleN += n;
            }
        }
    }
}
