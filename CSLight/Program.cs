using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretMessage = "Копай на восток до обеда!";
            string password = "1qaz2WSX";
            int countAttempts = 3;
            bool hasAccess = false;

            for(int i = 0; i < countAttempts; i++)
            {
                Console.Write("Введите пароль: ");
                string userInput = Console.ReadLine();
                
                if(userInput == password)
                {
                    Console.WriteLine($"Ваше тайное сообщение: {secretMessage}");
                    break;
                }
                else
                {
                    int remainingAttempts = countAttempts - i - 1;
                    Console.WriteLine($"Пароль не верный. Осталось {remainingAttempts} попыток");
                }
            }
        }
    }
}
