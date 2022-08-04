using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 5;
            int lastNumber = 96;
            int iterationStep = 7;

            //Выбираю for, т.к. есть четкое понимание до какого числа идет последовательность
            for(int i = startNumber; i != lastNumber; i += iterationStep)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(lastNumber);
        }
    }
}
