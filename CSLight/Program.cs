using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = 10;
            int[] arrayForMixing = CreateRandomArray(sizeArray);
            PrintArray(arrayForMixing);
            Shuffle(ref arrayForMixing);
            PrintArray(arrayForMixing);
        }

        private static void Shuffle(ref int[] array)
        {
            Random random = new Random();
            int firstIndexArray = 0;
            int lastIndexArray = array.Length - 1;

            for(int i = 0; i < array.Length; i++)
            {
                ChangePlaceElements(ref array, i, random.Next(firstIndexArray, lastIndexArray));
            }
        }

        private static void ChangePlaceElements(ref int[] array, int firstIndexForChanging, int secondIndexForChanging)
        {
            int storageForFirstElement = array[firstIndexForChanging];
            array[firstIndexForChanging] = array[secondIndexForChanging];
            array[secondIndexForChanging] = storageForFirstElement;
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " | ");
            }

            Console.WriteLine();
        }

        private static int[] CreateRandomArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            int minValueArray = 0;
            int maxValueArray = 100;

            for(int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValueArray, maxValueArray);
            }

            return array;
        }
    }
}
