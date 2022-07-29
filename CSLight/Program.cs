using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            String zodiacSign;
            int age;
            String workPlace;
            Console.Write("Как вас зовут: ");
            name = Console.ReadLine();
            Console.Write("Какой ваш знак зодиака: ");
            zodiacSign = Console.ReadLine();
            Console.Write("Сколько вам лет: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Где вы работаете: ");
            workPlace = Console.ReadLine();
            Console.WriteLine($"Вас зовут {name}, вам {age} год, вы {zodiacSign} и работаете на {workPlace}.");
        }
    }
}
