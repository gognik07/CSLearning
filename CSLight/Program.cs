using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int min = 0;
            int max = 101;
            int number = random.Next(min, max);
            int sum = 0;
            int multiplicityThree = 3;
            int multiplicityFive = 5;

            Console.WriteLine($"Выбрано число {number}");
            for(int i = 1; i <= number; i++)
            {
                if (i % multiplicityThree == 0 || i % multiplicityFive == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма чисел кратных 3 и 5 равна {sum}");
        }
    }
}
