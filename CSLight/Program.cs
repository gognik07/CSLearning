using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayForSearching = new int[10, 10];
            Random random = new Random();
            int minNumber = 0;
            int maxNumber = 50;
            int maxNumberInArray = int.MinValue;
            
            for(int i = 0; i < arrayForSearching.GetLength(0); i++)
            {
                for(int j = 0; j < arrayForSearching.GetLength(1); j++)
                {
                    arrayForSearching[i, j] = random.Next(minNumber, maxNumber);
                    Console.Write(arrayForSearching[i, j] + " | ");

                    if (maxNumberInArray < arrayForSearching[i, j])
                    {
                        maxNumberInArray = arrayForSearching[i, j];
                    }

                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nМаксимальное число в массиве = {maxNumberInArray}\n");

            for (int i = 0; i < arrayForSearching.GetLength(0); i++)
            {
                for (int j = 0; j < arrayForSearching.GetLength(1); j++)
                {
                    if (arrayForSearching[i, j] == maxNumberInArray)
                    {
                        arrayForSearching[i, j] = 0;
                    }

                    Console.Write(arrayForSearching[i, j] + " | ");
                }

                Console.WriteLine();
            }
        }
    }
}
