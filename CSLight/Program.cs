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
            String currentlyStorageForLastName = firstName;
            firstName = lastName;
            lastName = currentlyStorageForLastName;
            Console.WriteLine($"Стало: Имя - {firstName}, Фамилия - {lastName}");
        }
    }
}
