using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько у вас рублей: ");
            float countRub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас долларов: ");
            float countUsd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас евро: ");
            float countEuro = Convert.ToSingle(Console.ReadLine());
            int rubToUsd = 70;
            int rubToEuro = 140;
            int usdToEuro = 2;
            int numberCommand = -1;

            Console.WriteLine("Добро пожаловать в обменник!");
            while(numberCommand != 0)
            {
                Console.WriteLine($"\nУ вас есть {countRub} рублей, {countUsd} долларов, {countEuro} евро");
                Console.WriteLine("0 - Выход из программы\n" +
                    "1 - конвертация рублей в доллары\n" +
                    "2 - конвертация рублей в евро\n" +
                    "3 - конвертация долларов в рубли\n" +
                    "4 - конвертация долларов в евро\n" +
                    "5 - конвертация евро в рубли\n" +
                    "6 - конвертация евро в доллары");
                Console.Write("Выберите желаемое действие: ");
                numberCommand = Convert.ToInt32(Console.ReadLine());
                if (numberCommand == 0)
                {
                    continue;
                }
                Console.Write("Введите количество покупаемой валюты: ");
                int countBuyingCurrency = Convert.ToInt32(Console.ReadLine());
                switch(numberCommand)
                {
                    case 1:
                        countRub -= countBuyingCurrency * rubToUsd;
                        countUsd += countBuyingCurrency;
                        break;
                    case 2:
                        countRub -= countBuyingCurrency * rubToEuro;
                        countEuro += countBuyingCurrency;
                        break;
                    case 3:
                        countUsd -= Convert.ToSingle(countBuyingCurrency)/rubToUsd;
                        countRub += countBuyingCurrency;
                        break;
                    case 4:
                        countUsd -= countBuyingCurrency * usdToEuro;
                        countEuro += countBuyingCurrency;
                        break;
                    case 5:
                        countEuro -= Convert.ToSingle(countBuyingCurrency) / rubToEuro;
                        countRub += countBuyingCurrency;
                        break;
                    case 6:
                        countEuro -= Convert.ToSingle(countBuyingCurrency) / usdToEuro;
                        countUsd += countBuyingCurrency;
                        break;
                    default:
                        Console.WriteLine("Такой команды не существует");
                        break;
                }
            }
        }
    }
}
