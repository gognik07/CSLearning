using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите символ для обвода:");
            char characterOutline = Convert.ToChar(Console.ReadLine());

            string nameWithFrame = characterOutline + name + characterOutline;
            for(int i = 0; i < nameWithFrame.Length; i++)
            {
                Console.Write(characterOutline);
            }
            Console.WriteLine();
            Console.WriteLine(characterOutline + name + characterOutline);
            for (int i = 0; i < nameWithFrame.Length; i++)
            {
                Console.Write(characterOutline);
            }
        }
    }
}
