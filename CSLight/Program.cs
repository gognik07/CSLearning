using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayForCalculation = { 
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 } 
            };
            int countRowForSum = 1;
            int sumRow = 0;

            for (int i = 0; i < arrayForCalculation.GetLength(0); i++)
            {
                sumRow += arrayForCalculation[countRowForSum, i];
            }

            Console.WriteLine($"Сумма 2-ой строки равна {sumRow}");

            int countColForMultiplication = 0;
            int multiplicationCol = 1;

            for (int i = 0; i < arrayForCalculation.GetLength(1); i++)
            {
                multiplicationCol *= arrayForCalculation[i, countColForMultiplication];
            }

            Console.WriteLine($"Произведение первого столбца равно {multiplicationCol}");
        }
    }
}
