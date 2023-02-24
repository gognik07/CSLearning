using System;
using System.Collections.Generic;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> productBuckets = CreateProductBuckets();
            PrintBuckets(productBuckets);
            int sum = 0;

            while(productBuckets.Count > 0)
            {
                int sumOfBucket = productBuckets.Dequeue();
                Console.WriteLine($"Очередная сумма корзины: {sumOfBucket}");
                sum += sumOfBucket;
                Console.WriteLine($"Итоговая сумма за день: {sum}");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"День завершен! Вы заработали {sum} денег!");
        }

        private static void PrintBuckets(Queue<int> productBuckets)
        {
            Console.WriteLine("Очередь цен:");

            foreach(int sumBacket in productBuckets)
            {
                Console.WriteLine(sumBacket);
            }

            Console.ReadKey();
            Console.Clear();
        }

        private static Queue<int> CreateProductBuckets()
        {
            int minClients = 1;
            int maxClients = 5;
            int minSumBucket = 200;
            int maxSumBucket = 800;
            Random random = new Random();
            Queue<int> productBuckets = new Queue<int>();

            int countClients = random.Next(minClients, maxClients);
            for(int i = 0; i < countClients; i++)
            {
                int sumBucketForClient = random.Next(minSumBucket, maxSumBucket);
                productBuckets.Enqueue(sumBucketForClient);
            }
            return productBuckets;
        }
    }
}
