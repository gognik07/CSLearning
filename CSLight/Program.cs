using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите позицию по X: ");
            int positionX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите позицию по Y: ");
            int positionY = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите процент заполненности:");
            int percentFilling = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите символ для заолнения: ");
            char symbolForFilling = Console.ReadLine()[0];
            PrintBar(positionX, positionY, percentFilling, symbolForFilling);
            Console.ReadKey();
        }

        private static void PrintBar(int positionX, int positionY, int percentFilling, char symbolForFilling)
        {
            int fullSpace = 10;
            char emptySymbol = '_';

            if (percentFilling < 0 || percentFilling > 100)
            {
                Console.WriteLine("Некорректное количество процентов");
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(positionX, positionY);
                int fillingSpace = percentFilling / fullSpace;
                Console.Write("[");

                for(int i = 0; i < fillingSpace; i++)
                {
                    Console.Write(symbolForFilling);
                }

                for (int i = 0; i < fullSpace - fillingSpace; i++)
                {
                    Console.Write(emptySymbol);
                }

                Console.Write("]");
            }
            
            
            
        }
    }
}
