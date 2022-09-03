using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandAdd = "1";
            const string CommandPrint = "2";
            const string CommandDelete = "3";
            const string CommandFind = "4";
            const string CommandExit = "5";
            string[] fullNames = new string[0];
            string[] workingPositions = new string[0];
            bool isWorked = true;            

            while (isWorked)
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
                    case CommandAdd:
                        AddDossier(ref fullNames, ref workingPositions);                        
                        break;
                    case CommandPrint:
                        PrintDossiers(fullNames, workingPositions);                        
                        break;
                    case CommandDelete:
                        DeleteDossier(ref fullNames, ref workingPositions);                        
                        break;
                    case CommandFind:
                        FindDossier(fullNames, workingPositions);                        
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

        private static void DeleteDossier(ref string[] fullNames, ref string[] workingPositions)
        {
            Console.Write("Введите номер удаляемого досье: ");
            int numberDossier = Convert.ToInt32(Console.ReadLine());

            if(numberDossier < 1 || numberDossier > fullNames.Length)
            {
                Console.WriteLine("Досье с таким номером не существует");
            }
            else
            {
                fullNames[numberDossier - 1] = null;
                workingPositions[numberDossier - 1] = null;
                NarrowArray(ref fullNames);
                NarrowArray(ref workingPositions);
                Console.WriteLine("Досье удалено");                
            }

            Console.ReadKey();
            Console.Clear();
        }

        static void NarrowArray(ref string[] arrayForNarrowing)
        {
            string[] tempArray = new string[arrayForNarrowing.Length - 1];
            int currentTemporaryPosition = 0;

            for(int i = 0; i < arrayForNarrowing.Length; i++)
            {
                if (arrayForNarrowing[i] != null)
                {
                    tempArray[currentTemporaryPosition] = arrayForNarrowing[i];
                    currentTemporaryPosition++;
                }
            }

            arrayForNarrowing = tempArray;
        }

        private static void FindDossier(string[] fullNames, string[] workingPositions)
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

            Console.ReadKey();
            Console.Clear();
        }

        static void PrintDossiers(string[] fullNames, string[] workingPositions)
        {
            if(fullNames.Length == 0)
            {
                Console.WriteLine("Список с досье пуст");
            } 
            else
            {
                for (int i = 0; i < fullNames.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {fullNames[i]} - {workingPositions[i]}");
                }
            }

            Console.ReadKey();
            Console.Clear();
        }

        static void AddDossier(ref string[] fullNames, ref string[] workingPositions)
        {
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();
            Console.Write("Введите должность: ");
            string workingPosition = Console.ReadLine();
            ExpandArray(ref fullNames);
            ExpandArray(ref workingPositions);

            fullNames[fullNames.Length - 1] = fullName;
            workingPositions[workingPositions.Length - 1] = workingPosition;            
            Console.Clear();
        }

        static void ExpandArray(ref string[] arrayForExpanding)
        {
            string[] tempArray = new string[arrayForExpanding.Length + 1];

            for (int i = 0; i < arrayForExpanding.Length; i++)
            {
                tempArray[i] = arrayForExpanding[i];
            }

            arrayForExpanding = tempArray;
        }
    }
}
