using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCountPictures = 52;
            int countPicturesOnLine = 3;
            int fillingLines = totalCountPictures / countPicturesOnLine;
            int extraPictures = totalCountPictures % countPicturesOnLine;
            Console.WriteLine($"Заполненных рядов картинок {fillingLines}, осталось {extraPictures} картинок");
        }
    }
}
