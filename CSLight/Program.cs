using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int cristalPrice = 10;
            Console.Write("Сколько у вас золота: ");
            int gold = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Один кристал стоит {cristalPrice}. Сколько кристалов вы хотите купить: ");
            int countCristals = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"У вас есть {countCristals} кристалов и {gold - countCristals * cristalPrice} золота!");

        }
    }
}
