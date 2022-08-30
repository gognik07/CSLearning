using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fullNames = new string[0];
            string[] workingPositions = new string[0];
            bool isWorked = true;

            while(isWorked)
            {
                Console.WriteLine("Доступные команду:" +
                    "\n 1 - Добавить досье" +
                    "\n 2 - Вывести все досье" +
                    "\n 3 - Удалить досье" +
                    "\n 4 - поиск по фамилии" +
                    "\n 5 - выход");
                Console.Write("Введите номер команды: ");
                string commandNumber = Console.ReadLine();

                switch(commandNumber)
                {
                    case "1":
                        addDossier(ref fullNames, ref workingPositions);
                        Console.Clear();
                        break;
                    case "2":
                        printDossiers(fullNames, workingPositions);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        deleteDossier(ref fullNames, ref workingPositions);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        findDossier(fullNames, workingPositions);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
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

        private static void deleteDossier(ref string[] fullNames, ref string[] workingPositions)
        {
            Console.Write("Введите номер удаляемого досье: ");
            int numberDossier = Convert.ToInt32(Console.ReadLine());

            if(numberDossier < 1 || numberDossier > fullNames.Length)
            {
                Console.WriteLine("Досье с таким номером не существует");
            }
            else
            {
                string[] temporaryFullNames = new string[fullNames.Length - 1];
                string[] temporaryWorkingPositions = new string[workingPositions.Length - 1];
                int currentTemporaryPosition = 0;

                for(int i = 0; i < fullNames.Length; i++)
                {
                    if(i != numberDossier - 1)
                    {
                        temporaryFullNames[currentTemporaryPosition] = fullNames[i];
                        temporaryWorkingPositions[currentTemporaryPosition] = workingPositions[i];
                        currentTemporaryPosition++;
                    }
                }

                fullNames = temporaryFullNames;
                workingPositions = temporaryWorkingPositions;
                Console.WriteLine("Досье удалено");
            }
        }

        private static void findDossier(string[] fullNames, string[] workingPositions)
        {
            Console.Write("Введите фамилию для поиска: ");
            string lastname = Console.ReadLine();
            bool isFound = false;

            for(int i = 0; i < fullNames.Length; i++)
            {
                string[] names = fullNames[i].Split(' ');

                if (names[0].ToUpper().Equals(lastname.ToUpper()))
                {
                    Console.WriteLine($"{i + 1} - {fullNames[i]} - {workingPositions[i]}");
                    isFound = true;
                }
            }

            if(isFound == false)
            {
                Console.WriteLine("Досье с такой фамилией не найдено");
            }
        }

        static void printDossiers(string[] fullNames, string[] workingPositions)
        {
            if(fullNames.Length == 0)
            {
                Console.WriteLine("Список с досье пуст");
            }

            for(int i = 0; i < fullNames.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {fullNames[i]} - {workingPositions[i]}");
            }
        }

        static void addDossier(ref string[] fullNames, ref string[] workingPositions)
        {
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();
            Console.Write("Введите должность: ");
            string workingPosition = Console.ReadLine();
            string[] temporaryFullNames = new string[fullNames.Length + 1];
            string[] temporaryWorkingPositions = new string[workingPositions.Length + 1];

            for(int i = 0; i < fullNames.Length; i++)
            {
                temporaryFullNames[i] = fullNames[i];
                temporaryWorkingPositions[i] = workingPositions[i];
            }

            temporaryFullNames[temporaryFullNames.Length - 1] = fullName;
            temporaryWorkingPositions[temporaryWorkingPositions.Length - 1] = workingPosition;
            fullNames = temporaryFullNames;
            workingPositions = temporaryWorkingPositions;
        }
    }
}
