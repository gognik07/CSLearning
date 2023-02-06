using System;
using System.IO;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool isPlaying = true;
            char symbolHero = '@';
            char sympolFencing = '#';
            char symbolTreasure = 'X';
            char symbolTakenTreasure = 'O';
            string pathMap = "maps/map.txt";
            char[] bag = new char[0];
            int heroPositionX;
            int heroPositionY;

            Console.CursorVisible = false;
            char[,] map = ReadMap(pathMap, out heroPositionX, out heroPositionY, symbolHero);
            
            while (isPlaying)
            {
                DrawBag(bag);
                DrawMap(map);
                DrawHero(heroPositionY, heroPositionX, symbolHero);                
                MoveHero(map, ref heroPositionX, ref heroPositionY, ref bag, sympolFencing, symbolTreasure, symbolTakenTreasure);                
                Console.Clear();
            }
        }

        private static void DrawBag(char[] bag)
        {
            Console.SetCursorPosition(0, 12);
            Console.Write("Сумка: ");

            for(int i = 0; i < bag.Length; i++)
            {
                Console.Write(bag[i] + " ");
            }
        }

        private static void DrawHero(int heroPositionY, int heroPositionX, char symbolHero)
        {
            Console.SetCursorPosition(heroPositionY, heroPositionX);
            Console.Write(symbolHero);
        }

        private static void MoveHero(char[,] map, ref int heroPositionX, ref int heroPositionY, ref char[] bag, char sympolFencing, char symbolTreasure, char symbolTakenTreasure)
        {
            ConsoleKeyInfo charKey = Console.ReadKey(true);

            switch (charKey.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[heroPositionX - 1, heroPositionY] != sympolFencing)
                    {
                        heroPositionX--;
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (map[heroPositionX + 1, heroPositionY] != sympolFencing)
                    {
                        heroPositionX++;
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    if (map[heroPositionX, heroPositionY - 1] != sympolFencing)
                    {
                        heroPositionY--;
                    }
                    break;

                case ConsoleKey.RightArrow:
                    if (map[heroPositionX, heroPositionY + 1] != sympolFencing)
                    {
                        heroPositionY++;
                    }
                    break;
            }

            if (map[heroPositionX, heroPositionY] == symbolTreasure)
            {                
                AddTreasureInBag(map, heroPositionX, heroPositionY, ref bag, symbolTreasure, symbolTakenTreasure);
            }
        }

        private static void AddTreasureInBag(char[,] map, int heroPositionX, int heroPositionY, ref char[] bag, char symbolTreasure, char symbolTakenTreasure)
        {
            map[heroPositionX, heroPositionY] = symbolTakenTreasure;
            char[] tempBag = new Char[bag.Length + 1];

            for(int i = 0; i < bag.Length; i++)
            {
                tempBag[i] = bag[i];
            }

            tempBag[tempBag.Length - 1] = symbolTreasure;
            bag = tempBag;
        }

        static void DrawMap(char[,] map)
        {
            Console.SetCursorPosition(0, 0);
            for(int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }

                Console.WriteLine();
            }
        }

        static char[,] ReadMap(string pathMapFile, out int heroPositionX, out int heroPositionY, char symbolHero)
        {
            heroPositionX = 0;
            heroPositionY = 0;

            string[] fileStrings = File.ReadAllLines(pathMapFile);
            char[,] map = new char[fileStrings.Length, fileStrings[0].Length];

            for(int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = fileStrings[i][j];

                    if(map[i, j] == symbolHero)
                    {
                        heroPositionX = i;
                        heroPositionY = j;
                        map[i, j] = ' ';
                    }
                }
            }

            return map;
        }
    }
}
