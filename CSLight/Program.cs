using System;
using System.Collections.Generic;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandAdd = "1";
            const string CommandPrint = "2";
            const string CommandDelete = "3";
            const string CommandExit = "4";
            Dictionary<string, string> accountings = new Dictionary<string, string>();
            bool isWorked = true;            

            while (isWorked)
            {
                Console.WriteLine("Доступные команду:" +
                    "\n 1 - Добавить досье" +
                    "\n 2 - Вывести все досье" +
                    "\n 3 - Удалить досье" +
                    "\n 4 - выход");
                Console.Write("Введите номер команды: ");
                string commandNumber = Console.ReadLine();

                switch(commandNumber)
                {
                    case CommandAdd:
                        AddDossier(accountings);                        
                        break;
                    case CommandPrint:
                        PrintDossiers(accountings);                        
                        break;
                    case CommandDelete:
                        DeleteDossier(accountings);                        
                        break;
                    case CommandExit:
                        isWorked = false;
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        private static void DeleteDossier(Dictionary<string, string> accountings)
        {
            Console.Write("Введите имя удаляемого досье: ");
            string fullName = Console.ReadLine();

            if(accountings.Remove(fullName))
            {
                Console.WriteLine("Досье удалено");
            }
            else
            {                
                Console.WriteLine("Досье с таким именем не существует");                
            }

            Console.ReadKey();
            Console.Clear();
        }

        static void PrintDossiers(Dictionary<string, string> accountings)
        {
            if (accountings.Count == 0)
            {
                Console.WriteLine("Список с досье пуст");
            }
            else
            {
                foreach(string fullName in accountings.Keys)
                {
                    Console.WriteLine($"{fullName} - {accountings[fullName]}");
                }                
            }

            Console.ReadKey();
            Console.Clear();
        }

        static void AddDossier(Dictionary<string, string> accountings)
        {
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();
            if (accountings.ContainsKey(fullName))
            {
                Console.WriteLine("Такое ФИО уже существует!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Write("Введите должность: ");
                string workingPosition = Console.ReadLine();
                accountings.Add(fullName, workingPosition);
                Console.Clear();
            }
        }
    }
}
