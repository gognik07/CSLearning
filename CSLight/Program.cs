using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "start";

            while(command.ToLower() != "exit")
            {
                Console.WriteLine($"Выполняется команда {command}...");
                Console.Write("Введите команду: ");
                command = Console.ReadLine();               
            }

            Console.WriteLine("До свидания!");
        }
    }
}
