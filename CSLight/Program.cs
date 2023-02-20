using System;
using System.Collections.Generic;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorked = true;

            Dictionary<string, string> dictionary = InitializationDictionary();

            while(isWorked)
            {
                Console.Write("Введите интересующее вас слово:");
                string word = Console.ReadLine();
                GetDescriptionOfWord(dictionary, word, ref isWorked);
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void GetDescriptionOfWord(Dictionary<string, string> dictionary, string word, ref bool isWorked)
        {
            word = word.ToUpper();

            if (word == "EXIT")
            {
                isWorked = false;
            } else if (dictionary.ContainsKey(word))
            {
                Console.WriteLine(dictionary[word]);
            } else
            {
                Console.WriteLine("Такого слова нет в словаре");
            }
        }

        private static Dictionary<string, string> InitializationDictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("ДАННЫЕ", "Сведения, необходимые для какого-н. вывода, решения");
            dictionary.Add("ЛАНИТА", "То же, что щека");
            dictionary.Add("ЛЕСИНА", "Срубленное дерево");
            dictionary.Add("ПАНАМА", "Летняя матерчатая шляпа с мягкими полями");
            dictionary.Add("ПАССАТ", "Устойчивый ветер в тропических широтах океанов");
            dictionary.Add("ПЕРЕВОДЧИК", "Специалист по переводам с одного языка на другой");
            dictionary.Add("ТАНКЕР", "Судно для перевозки жидких грузов в танках");
            dictionary.Add("ФАНАБЕРИЯ", "Кичливость, спесь, мелкое чванство");
            dictionary.Add("ИЗОБАРА", "Линия на графике, соединяющая местаодинакового атмосферного давления");
            dictionary.Add("ШКИВ", "Колесо с широким ободом, детальременной или канатной передачи");
            return dictionary;
        }
    }
}
