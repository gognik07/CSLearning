using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите скобочное выражение:");
            string bracketExpression = Console.ReadLine();
            int countOpenedBrackets = 0;
            int nestingDepth = 0;
            bool isCorrectExpression = true;

            for(int i = 0; i < bracketExpression.Length; i++)
            {
                if (bracketExpression[i] == '(')
                {
                    countOpenedBrackets++;
                }
                else if (bracketExpression[i] == ')')
                {
                    countOpenedBrackets--;
                }
                else
                {
                    Console.WriteLine($"Недопустимый символ в скобочном выражении {bracketExpression[i]}");
                    isCorrectExpression = false;
                    break;
                }

                if (countOpenedBrackets < 0)
                {
                    isCorrectExpression = false;
                    break;
                }

                if (countOpenedBrackets > nestingDepth)
                {
                    nestingDepth = countOpenedBrackets;
                }
            }

            if (countOpenedBrackets == 0 && isCorrectExpression)
            {
                Console.WriteLine($"Строка корректная и максимум глубины равняется {nestingDepth}");
            }
            else
            {
                Console.WriteLine("Не корректное выражение");
            }
        }
    }
}
