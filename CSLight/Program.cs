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
            int choosedNumber = random.Next(minN, maxN);
            Console.WriteLine($"N = {choosedNumber}");
            int minMultiple = 100;
            int maxMultiple = 1000;
            int resultMultipleN = choosedNumber;

            while(resultMultipleN < maxMultiple)
            {
                if (resultMultipleN >= minMultiple)
                {
                    Console.WriteLine(resultMultipleN);
                }
                resultMultipleN += choosedNumber;
            }
        }
    }
}
