using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            string textForSpliting = "Lorem ipsum dolor sit amet consectetur adipiscing elit";
            char separator = ' ';
            string[] arrayFromText = textForSpliting.Split(separator);

            for(int i = 0; i < arrayFromText.GetLength(0); i++)
            {
                Console.WriteLine(arrayFromText[i]);
            }
        }
    }
}
