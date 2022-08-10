using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {          
            int heroHealth = 3500;
            int heroStandartDamage = 130;
            int minFireDamage = 40;
            int maxFireDamage = 80;
            int maxCountBurning = 3;
            int remainingCountBurning = 0;
            bool isFreezedBoss = false;
            int minStealingLife = 30;
            int maxStealingLife = 70;
            bool hasBurnedSword = false;
            bool hasFreezedSword = false;
            bool hasVimpireSword = false;
            int bossHealth = 2000;
            int bossStandartDamage = 150;
            int bossMinGain = 1;
            int bossMaxGain = 3;
            Random random = new Random();
            int incrementRandomMax = 1;

            Console.WriteLine("Правила игры:\n" +
                "Вы маг-кузнец-мечник.У вас есть 4 способности:\n" +
                "\tUrulocelango - Создать огненный меч\n" +
                "\tHelcalango - Создать ледяной меч\n" +
                "\tCuilelango - Создать вампирский меч\n" +
                "\tSic - Ударить созданным мечом\n" +
                "Вам нужно сразиться с боссом. Вы ходите ход за ходом." +
                "Без меча вы не можете ударить босса. При создании нового меча предыдущий пропадает.\n" +
                $"Огненный меч поджигает врага и наносит дополнительный урон на протяжении {maxCountBurning} ходов. Поджеги не суммируются, если боссу гореть ещё 2 хода, а вы его подожжете, то он будет гореть {maxCountBurning} хода, а не 5.\n" +
                "Ледяной меч после удара замораживает босса.\n" +
                "Вампирский меч часть нанесенного удара добавляет герою.\n" +
                $"Босс отвечает ударом, но может пасть в неистовство и урон будет увеличен в {bossMinGain}-{bossMaxGain} раза");

            while(heroHealth > 0 && bossHealth > 0)
            {
                Console.Write("\nВыберите способность:");
                string heroAction = Console.ReadLine().ToUpper();
                bool isCorrectAction = true;

                switch(heroAction)
                {
                    case "URULOCELANGO":
                        hasFreezedSword = false;
                        hasVimpireSword = false;
                        hasBurnedSword = true;
                        Console.WriteLine("Вы создали огненный меч");
                        break;
                    case "HELCALANGO":
                        hasVimpireSword = false;
                        hasBurnedSword = false;
                        hasFreezedSword = true;
                        Console.WriteLine("Вы создали ледяной меч");
                        break;
                    case "CUILELANGO":                        
                        hasBurnedSword = false;
                        hasFreezedSword = false;
                        hasVimpireSword = true;
                        Console.WriteLine("Вы создали вампирский меч");
                        break;
                    case "SIC":
                        if (hasBurnedSword == false && hasFreezedSword == false && hasVimpireSword == false)
                        {
                            Console.WriteLine("У вас нет меча для удара");
                            isCorrectAction = false;
                            break;
                        }
                        else if (hasBurnedSword)
                        {
                            remainingCountBurning = maxCountBurning;
                        } 
                        else if (hasFreezedSword)
                        {
                            isFreezedBoss = true;
                        }
                        else
                        {
                            heroHealth += random.Next(minStealingLife, maxStealingLife);
                        }

                        bossHealth -= heroStandartDamage;
                        break;
                    default:
                        Console.WriteLine("Такого действия нет");
                        isCorrectAction = false;
                        break;
                }

                if (isCorrectAction == false)
                {
                    continue;
                }

                if (isFreezedBoss == false)
                {
                    heroHealth -= bossStandartDamage * random.Next(bossMinGain, bossMaxGain + incrementRandomMax);
                }
                else
                {
                    Console.WriteLine("Босс обездвижен");
                    isFreezedBoss = false;
                }
                
                if (remainingCountBurning > 0)
                {
                    Console.WriteLine("Огонь убивает босса");
                    bossHealth -= random.Next(minFireDamage, maxFireDamage);
                    remainingCountBurning--;
                }

                Console.WriteLine($"У вас осталось {heroHealth} жизней, у босса осталось {bossHealth} жизней.");
            }

            if (heroHealth <= 0 && bossHealth <= 0)
            {
                Console.WriteLine("Все мертвы");
            }
            else if (heroHealth <= 0)
            {
                Console.WriteLine("Герой мертв");
            }
            else
            {
                Console.WriteLine("Босс мертв");
            }
        }
    }
}
