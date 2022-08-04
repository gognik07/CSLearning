using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            while(true)
            {
                Console.Write("Введите команду: ");
                command = Console.ReadLine();
                Console.WriteLine($"Выполняется команда {command}...");
                if (command == "exit")
                {
                    break;
                }
            }

            Console.WriteLine("До свидания!");
        }
    }
}
