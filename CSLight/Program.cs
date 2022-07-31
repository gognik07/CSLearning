using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Иванов";
            string lastName = "Петр";
            Console.WriteLine($"Было: Имя - {firstName}, Фамилия - {lastName}");
            string currentlyStorageForLastName = firstName;
            firstName = lastName;
            lastName = currentlyStorageForLastName;
            Console.WriteLine($"Стало: Имя - {firstName}, Фамилия - {lastName}");
        }
    }
}
