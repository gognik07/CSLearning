using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            int countRepetitions;

            Console.Write("Введите дублируемое сообщение: ");
            message = Console.ReadLine();
            Console.Write("Введите количесво повторений: ");
            countRepetitions = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < countRepetitions; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
