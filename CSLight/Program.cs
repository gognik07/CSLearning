using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber = 1;
            int maxNumber = 100;
            int comparedNumber = random.Next(minNumber, maxNumber);
            int powerTwo = 1;
            int basePower = 2;
            int resultPowerTwo = basePower;

            while(resultPowerTwo <= comparedNumber)
            {
                resultPowerTwo *= basePower;
                powerTwo++;
            }

            Console.WriteLine($"Выбранное число = {comparedNumber}, " +
                $"полученная степень двойки - {powerTwo}, " +
                $"два в степень {powerTwo} - {resultPowerTwo}");
        }
    }
}
