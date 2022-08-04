using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 101);
            int sum = 0;

            Console.WriteLine($"Выбрано число {number}");
            for(int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма чисел кратных 3 и 5 равна {sum}");
        }
    }
}
