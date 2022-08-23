using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = new int[20];
            Random random = new Random();
            int minRandom = 0;
            int maxRandom = 100;

            Console.WriteLine("Неотсортированный массив:");

            for (int i = 0; i < sortedArray.GetLength(0); i++)
            {
                sortedArray[i] = random.Next(minRandom, maxRandom);
                Console.Write(sortedArray[i] + " | ");
            }

            for (int i = 0; i < sortedArray.GetLength(0) - 1; i++)
            {
                for (int j = i; j < sortedArray.GetLength(0); j++)
                {
                    if (sortedArray[i] > sortedArray[j])
                    {
                        int currentStorageForChangedElement = sortedArray[i];
                        sortedArray[i] = sortedArray[j];
                        sortedArray[j] = currentStorageForChangedElement;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив:");

            for (int i = 0; i < sortedArray.GetLength(0); i++)
            {
                Console.Write(sortedArray[i] + " | ");
            }
        }
    }
}
