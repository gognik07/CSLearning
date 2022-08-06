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
            float rubToUsd = 70;
            float usdToRub = 1 / rubToUsd;
            float rubToEuro = 140;
            float euroToRub = 1 / rubToEuro;
            float usdToEuro = 2;
            float euroToUsd = 1 / usdToEuro;
            float numberCommand;
            bool isFinishedWork = false;

            Console.WriteLine("Добро пожаловать в обменник!");
            while(isFinishedWork == false)
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
                    isFinishedWork = true;
                }
                else
                {
                    Console.Write("Введите количество покупаемой валюты: ");
                    int countBuyingCurrency = Convert.ToInt32(Console.ReadLine());
                    switch (numberCommand)
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
                            countUsd -= Convert.ToSingle(countBuyingCurrency) * usdToRub;
                            countRub += countBuyingCurrency;
                            break;
                        case 4:
                            countUsd -= countBuyingCurrency * usdToEuro;
                            countEuro += countBuyingCurrency;
                            break;
                        case 5:
                            countEuro -= Convert.ToSingle(countBuyingCurrency) * euroToRub;
                            countRub += countBuyingCurrency;
                            break;
                        case 6:
                            countEuro -= Convert.ToSingle(countBuyingCurrency) * euroToUsd;
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
}
