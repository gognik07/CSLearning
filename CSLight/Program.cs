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
            float countEur = Convert.ToSingle(Console.ReadLine());
            float rubToUsd = 70;
            float usdToRub = 1 / rubToUsd;
            float rubToEur = 140;
            float eurToRub = 1 / rubToEur;
            float usdToEur = 2;
            float eurToUsd = 1 / usdToEur;
            string numberCommand;
            int countBuyingCurrency;
            bool isCompletedCommand;
            bool isFinishedWork = false;

            Console.WriteLine("Добро пожаловать в обменник!");

            while (isFinishedWork == false)
            {
                Console.WriteLine($"\nУ вас есть {countRub} рублей, {countUsd} долларов, {countEur} евро");
                Console.WriteLine("0 - Выход из программы\n" +
                    "1 - конвертация рублей в доллары\n" +
                    "2 - конвертация рублей в евро\n" +
                    "3 - конвертация долларов в рубли\n" +
                    "4 - конвертация долларов в евро\n" +
                    "5 - конвертация евро в рубли\n" +
                    "6 - конвертация евро в доллары");
                Console.Write("Выберите желаемое действие: ");
                numberCommand = Console.ReadLine();
                switch (numberCommand)
                {
                    case "0":
                        isFinishedWork = true;
                        break;
                    case "1":
                        Console.Write("Введите количество покупаемой валюты: ");
                        countBuyingCurrency = Convert.ToInt32(Console.ReadLine());
                        isCompletedCommand = countRub >= countBuyingCurrency * rubToUsd;
                        countRub -= countBuyingCurrency * rubToUsd * Convert.ToInt32(isCompletedCommand);
                        countUsd += countBuyingCurrency * Convert.ToInt32(isCompletedCommand);
                        break;
                    case "2":
                        Console.Write("Введите количество покупаемой валюты: ");
                        countBuyingCurrency = Convert.ToInt32(Console.ReadLine());
                        isCompletedCommand = countRub >= countBuyingCurrency * rubToEur;
                        countRub -= countBuyingCurrency * rubToEur * Convert.ToInt32(isCompletedCommand);
                        countEur += countBuyingCurrency * Convert.ToInt32(isCompletedCommand);
                        break;
                    case "3":
                        Console.Write("Введите количество покупаемой валюты: ");
                        countBuyingCurrency = Convert.ToInt32(Console.ReadLine());
                        isCompletedCommand = countUsd >= countBuyingCurrency * usdToRub;
                        countUsd -= countBuyingCurrency * usdToRub * Convert.ToInt32(isCompletedCommand);
                        countRub += countBuyingCurrency * Convert.ToInt32(isCompletedCommand);
                        break;
                    case "4":
                        Console.Write("Введите количество покупаемой валюты: ");
                        countBuyingCurrency = Convert.ToInt32(Console.ReadLine());
                        isCompletedCommand = countUsd >= countBuyingCurrency * usdToEur; 
                        countUsd -= countBuyingCurrency * usdToEur * Convert.ToInt32(isCompletedCommand);
                        countEur += countBuyingCurrency * Convert.ToInt32(isCompletedCommand);
                        break;
                    case "5":
                        Console.Write("Введите количество покупаемой валюты: ");
                        countBuyingCurrency = Convert.ToInt32(Console.ReadLine());
                        isCompletedCommand = countEur >= countBuyingCurrency * eurToRub; 
                        countEur -= countBuyingCurrency * eurToRub * Convert.ToInt32(isCompletedCommand);
                        countRub += countBuyingCurrency * Convert.ToInt32(isCompletedCommand);
                        break;
                    case "6":
                        Console.Write("Введите количество покупаемой валюты: ");
                        countBuyingCurrency = Convert.ToInt32(Console.ReadLine());
                        isCompletedCommand = countEur >= countBuyingCurrency * eurToUsd;
                        countEur -= countBuyingCurrency * eurToUsd * Convert.ToInt32(isCompletedCommand);
                        countUsd += countBuyingCurrency * Convert.ToInt32(isCompletedCommand);
                        break;
                    default:
                        Console.WriteLine("Такой команды не существует");
                        break;
                }
            }
        }
    }
}
