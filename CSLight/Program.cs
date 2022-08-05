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

            int widthOutline = 1;
            int widthFrame = widthOutline + name.Length + widthOutline;
            int heightOutline = 3;
            int numberNameLine = 1;
            for(int i = 0; i < heightOutline; i++)
            {
                if (i == numberNameLine)
                {
                    Console.WriteLine(characterOutline + name + characterOutline);
                } 
                else
                {
                    for (int j = 0; j < widthFrame; j++)
                    {
                        Console.Write(characterOutline);
                    }
                    Console.WriteLine();
                }

                
            }
        }
    }
}
