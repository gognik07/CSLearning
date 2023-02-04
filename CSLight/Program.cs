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
            int heroX, heroY;

            Console.CursorVisible = false;
            char[,] map = ReadMap(pathMap, out heroX, out heroY, symbolHero);
            
            while (isPlaying)
            {
                DrawBag(bag);
                DrawMap(map);
                DrawHero(heroY, heroX, symbolHero);                
                MoveHero(map, ref heroX, ref heroY, ref bag, sympolFencing, symbolTreasure, symbolTakenTreasure);                
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

        private static void DrawHero(int heroY, int heroX, char symbolHero)
        {
            Console.SetCursorPosition(heroY, heroX);
            Console.Write(symbolHero);
        }

        private static void MoveHero(char[,] map, ref int heroX, ref int heroY, ref char[] bag, char sympolFencing, char symbolTreasure, char symbolTakenTreasure)
        {
            ConsoleKeyInfo charKey = Console.ReadKey(true);

            switch (charKey.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[heroX - 1, heroY] != sympolFencing)
                    {
                        heroX--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (map[heroX + 1, heroY] != sympolFencing)
                    {
                        heroX++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (map[heroX, heroY - 1] != sympolFencing)
                    {
                        heroY--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (map[heroX, heroY + 1] != sympolFencing)
                    {
                        heroY++;
                    }
                    break;
            }

            if (map[heroX, heroY] == symbolTreasure)
            {                
                addTreasureInBag(map, heroX, heroY, ref bag, symbolTreasure, symbolTakenTreasure);
            }
        }

        private static void addTreasureInBag(char[,] map, int heroX, int heroY, ref char[] bag, char symbolTreasure, char symbolTakenTreasure)
        {
            map[heroX, heroY] = symbolTakenTreasure;
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

        static char[,] ReadMap(string pathMapFile, out int heroX, out int heroY, char symbolHero)
        {
            heroX = 0;
            heroY = 0;

            string[] fileStrings = File.ReadAllLines(pathMapFile);
            char[,] map = new char[fileStrings.Length, fileStrings[0].Length];

            for(int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = fileStrings[i][j];

                    if(map[i, j] == symbolHero)
                    {
                        heroX = i;
                        heroY = j;
                        map[i, j] = ' ';
                    }
                }
            }

            return map;
        }
    }
}
