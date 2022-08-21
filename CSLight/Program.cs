using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayForSum = new int[0];
            int arrayIncrement = 1;
            bool isWorked = true;

            while(isWorked)
            {
                Console.Write("Введите число для будущего сложения или команду sum или exit: ");
                string command = Console.ReadLine();

                switch(command)
                {
                    case "exit":
                        isWorked = false;
                        break;
                    case "sum":
                        int sum = 0;

                        for(int i = 0; i < arrayForSum.GetLength(0); i++)
                        {
                            sum += arrayForSum[i];
                        }

                        Console.WriteLine($"Сумма введенных чисел равна {sum}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        int[] tempArrayForSum = new int[arrayForSum.GetLength(0) + arrayIncrement];

                        for(int i = 0; i < arrayForSum.GetLength(0); i++)
                        {
                            tempArrayForSum[i] = arrayForSum[i];
                        }

                        tempArrayForSum[arrayForSum.GetLength(0)] = Convert.ToInt32(command);
                        arrayForSum = tempArrayForSum;

                        Console.Clear();
                        break;
                }
            }
        }
    }
}
