using System;
using System.Collections.Generic;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorked = true;
            List<int> listNumbers = new List<int>();

            while(isWorked)
            {
                Console.Write("Введите число: ");
                string command = Console.ReadLine();
                int number;

                if (command == "sum")
                {
                    isWorked = false;
                } else if (int.TryParse(command, out number))
                {
                    listNumbers.Add(number);
                } else
                {
                    Console.WriteLine("Введено не число");
                }

                Console.ReadKey();
                Console.Clear();
            }

            int sum = CalculateSum(listNumbers);
            Console.WriteLine($"Полученная сумма: {sum}");
        }

        private static int CalculateSum(List<int> listNumbers)
        {
            int sum = 0;

            foreach(int number in listNumbers) {
                sum += number;
            }

            return sum;
        }
    }
}
