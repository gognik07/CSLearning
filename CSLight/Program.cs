using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCountPictures = 52;
            int countPicturesOnLine = 3;
            int fillingLines = 52 / 3;
            int extraPictures = 52 % 3;
            Console.WriteLine($"Заполненных рядов картинок {fillingLines}, осталось {extraPictures} картинок");
        }
    }
}
