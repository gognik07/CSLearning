using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayForShifting = new int[10];
            Random random = new Random();
            int minRandom = 0;
            int maxRandom = 100;
            int indexLastArrayElement = arrayForShifting.GetLength(0) - 1;

            Console.WriteLine("Массив до сдвига:");

            for (int i = 0; i < arrayForShifting.GetLength(0); i++)
            {
                arrayForShifting[i] = random.Next(minRandom, maxRandom);
                Console.Write(arrayForShifting[i] + " | ");
            }

            Console.Write("\nВведите колличество сдвигов влево: ");
            int countShifting = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countShifting; i++)
            {
                int firstArrayElement = arrayForShifting[0];

                for(int j = 0; j < indexLastArrayElement; j++)
                {
                    arrayForShifting[j] = arrayForShifting[j + 1];
                }

                arrayForShifting[indexLastArrayElement] = firstArrayElement;
            }

            Console.WriteLine("Массив после сдвига:");

            for (int i = 0; i < arrayForShifting.GetLength(0); i++)
            {
                Console.Write(arrayForShifting[i] + " | ");
            }
        }
    }
}
