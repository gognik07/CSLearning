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
            int maxRandom = 5;

            for(int i = 0; i < arrayForSearching.GetLength(0); i++)
            {
                arrayForSearching[i] = random.Next(minRandom, maxRandom);
                Console.Write(arrayForSearching[i] + " | ");
            }

            int maxCountRepeating = 0;
            int maxRepeatingNumber = int.MinValue;
            int currentCountRepeating = 0;
            int currentNumber = int.MinValue;

            for(int i = 0; i < arrayForSearching.GetLength(0); i++)
            {

                if (arrayForSearching[i] != currentNumber)
                {

                    if (maxCountRepeating < currentCountRepeating)
                    {
                        maxCountRepeating = currentCountRepeating;
                        maxRepeatingNumber = currentNumber;
                    }

                    currentCountRepeating = 1;
                    currentNumber = arrayForSearching[i];
                } else
                {
                    currentCountRepeating++;
                }
            }

            Console.WriteLine($"число {maxRepeatingNumber} повторяется {maxCountRepeating} раз");
        }
    }
}
