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
            string outline = "";
            for(int i = 0; i < nameWithFrame.Length; i++)
            {
                outline += characterOutline;
            }

            Console.WriteLine(outline);
            Console.WriteLine(nameWithFrame);
            Console.WriteLine(outline);
        }
    }
}
