using System;
using System.Collections.Generic;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clients = CreateClients();
            int sum = 0;

            while(clients.Count > 0)
            {
                String client = clients.Dequeue();
                Queue<int> items = CreateItems(client);
                sum += CalculateSumOfClient(items);
                Console.WriteLine($"Сумма на счете: {sum}");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"День завершен! Вы заработали {sum} денег!");
        }

        private static int CalculateSumOfClient(Queue<int> items)
        {
            int sum = 0;

            while(items.Count > 0)
            {
                sum += items.Dequeue();
            }

            return sum;
        }

        private static Queue<int> CreateItems(string client)
        {
            Queue<int> items = new Queue<int>();
            if(client == "Ivan")
            {
                items.Enqueue(100);
                items.Enqueue(250);
                items.Enqueue(30);
                items.Enqueue(1000);
            } else if (client == "Petr")
            {
                items.Enqueue(300);
                items.Enqueue(550);
                items.Enqueue(700);
            } else
            {
                items.Enqueue(8000);
                items.Enqueue(800);
                items.Enqueue(80);
                items.Enqueue(8);
            }

            return items;
        }

        private static Queue<string> CreateClients()
        {
            Queue<String> clients = new Queue<string>();
            clients.Enqueue("Ivan");
            clients.Enqueue("Petr");
            clients.Enqueue("Olga");
            return clients;
        }
    }
}
