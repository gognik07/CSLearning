using System;
using System.Collections.Generic;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = new List<string>() { "1", "3",  "4", "1", "5"};
            Console.WriteLine("Первый список:");
            PrintList(firstList);
            List<string> secondList = new List<string>() { "1", "2",  "4", "6", "5", "5"};
            Console.WriteLine("Второй список:");
            PrintList(secondList);
            List<string> unionedList = UnionLists(firstList, secondList);
            Console.WriteLine("Объединенный список:");
            PrintList(unionedList);
        }

        private static void PrintList(List<string> printedList)
        {
            foreach(string value in printedList)
            {
                Console.WriteLine(value);
            }
        }

        private static List<string> UnionLists(List<string> firstList, List<string> secondList)
        {
            List<string> unionedList = new List<string>();
            AddUniqueValuesFromList(unionedList, firstList);
            AddUniqueValuesFromList(unionedList, secondList);
            return unionedList;
        }

        private static void AddUniqueValuesFromList(List<string> finalList, List<string> addedList)
        {
            foreach(string value in addedList)
            {
                if (finalList.Contains(value) == false)
                {
                    finalList.Add(value);
                }
            }
        }
    }
}
