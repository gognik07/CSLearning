using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            string name = "user";
            string password = "admin123";
            bool isFinish = false;

            while(isFinish == false)
            {
                Console.Clear();
                Console.WriteLine("\nДоступные команды:\n" +
                    "SetName – установить имя\n" +
                    "ChangeConsoleColor- изменить цвет консоли\n" +
                    "ChangeTextColor- изменить цвет текста\n" +
                    "SetWidth - установить ширину консоли\n" +
                    "SetHeight - установить высоту консоли\n" +
                    "SetPassword – установить пароль\n" +
                    "WriteName – вывести имя (после ввода пароля)\n" +
                    "Esc – выход из программы");
                Console.Write("Введите команду:");
                command = Console.ReadLine().ToUpper();

                switch(command)
                {
                    case "SETNAME":
                        Console.Write("Введите имя:");
                        name = Console.ReadLine();
                        break;
                    case "CHANGECONSOLECOLOR":
                        Console.Write("Выберите один из возможных цветов(Красный, зеленый, синий):");
                        string backgroundColor = Console.ReadLine().ToUpper();

                        switch (backgroundColor)
                        {
                            case "КРАСНЫЙ":
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            case "ЗЕЛЕНЫЙ":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "СИНИЙ":
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            default:
                                Console.WriteLine("Нет такого цвета");
                                Console.ReadKey();
                                break;
                        }    
                        
                        break;
                    case "CHANGETEXTCOLOR":
                        Console.Write("Выберите один из возможных цветов(Красный, зеленый, синий):");
                        string textColor = Console.ReadLine().ToUpper();

                        switch (textColor)
                        {
                            case "КРАСНЫЙ":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "ЗЕЛЕНЫЙ":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case "СИНИЙ":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            default:
                                Console.WriteLine("Нет такого цвета");
                                Console.ReadKey();
                                break;
                        }

                        break;
                    case "SETWIDTH":
                        Console.Write("Введите желаемую ширину:");
                        Console.WindowWidth = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "SETHEIGHT":
                        Console.Write("Введите желаемую высоту:");
                        Console.WindowHeight = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "SETPASSWORD":
                        Console.Write("Введите пароль:");
                        password = Console.ReadLine();
                        break;
                    case "WRITENAME":
                        Console.Write("Введите пароль:");

                        if (Console.ReadLine() == password)
                        {
                            Console.WriteLine(name);
                        }
                        else
                        {
                            Console.WriteLine("Неверный пароль");
                        }

                        Console.ReadKey();
                        break;
                    case "ESC":
                        isFinish = true;
                        break;
                    default:
                        Console.WriteLine("Нет такой команды");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
