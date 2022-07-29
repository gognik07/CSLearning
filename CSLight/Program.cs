using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = "Иванов";
            String lastName = "Петр";
            Console.WriteLine($"Было: Имя - {firstName}, Фамилия - {lastName}");
            String currentlyStorageForName = firstName;
            firstName = lastName;
            lastName = currentlyStorageForName;
            Console.WriteLine($"Стало: Имя - {firstName}, Фамилия - {lastName}");
        }
    }
}
