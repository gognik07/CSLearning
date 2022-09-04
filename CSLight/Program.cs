using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadInt();
        }

        private static void ReadInt()
        {
            bool isCorrectNumber = false;
            int inputNumber = 0;
            
            while(isCorrectNumber == false)
            {
                Console.Write("Введите число: ");
                isCorrectNumber = int.TryParse(Console.ReadLine(), out inputNumber);
            }

            Console.WriteLine("Введено число: " + inputNumber);
        }
    }
}
