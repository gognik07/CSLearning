using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReadInt());
        }

        private static int ReadInt()
        {
            bool isCorrectNumber = false;
            int inputNumber = 0;
            
            while(isCorrectNumber == false)
            {
                Console.Write("Введите число: ");
                isCorrectNumber = int.TryParse(Console.ReadLine(), out inputNumber);
            }

            return inputNumber;
        }
    }
}
