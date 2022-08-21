using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayForSearching = new int[30];
            Random random = new Random();
            int minRandom = 0;
            int maxRandom = 100;
            int indexFirstElement = 0;
            int indexLastElement = arrayForSearching.GetLength(0) - 1;

            for (int i = 0; i < arrayForSearching.GetLength(0); i++)
            {
                arrayForSearching[i] = random.Next(minRandom, maxRandom);
                Console.Write(arrayForSearching[i] + " | ");
            }

            Console.WriteLine();

            for (int i = 0; i < arrayForSearching.GetLength(0); i++)
            {
                if (i == indexFirstElement)
                {
                    if (arrayForSearching[i] >= arrayForSearching[i + 1])
                    {
                        Console.WriteLine($"Локальный максимум {arrayForSearching[i]} в позиции {i}");
                    }
                } else if (i == indexLastElement)
                {
                    if (arrayForSearching[i] >= arrayForSearching[i - 1])
                    {
                        Console.WriteLine($"Локальный максимум {arrayForSearching[i]} в позиции {i}");
                    }
                } else
                {
                    if (arrayForSearching[i] >= arrayForSearching[i + 1] && arrayForSearching[i] >= arrayForSearching[i - 1])
                    {
                        Console.WriteLine($"Локальный максимум {arrayForSearching[i]} в позиции {i}");
                    }
                }
            }
        }
    }
}
