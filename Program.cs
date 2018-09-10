using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp7
{
    class Tama
    {
        public static int health = 50;
        public static int happiness = 50;
        public static int satiety = 50;
        public static string name;
        public static int personage;

        public static int SelectPersonage()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                   1. Кошечка");
            Console.WriteLine("                   2. Скелет");
            Console.WriteLine("                   3. Кролик");
            Console.Write("             Выберите себе питомца: ");
            personage = int.Parse(Console.ReadLine());
            for(; personage>3 || personage < 1;)
            {
                Console.Write("     Вы, должно быть, ошиблись, перевыберите: ");
                personage = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("             Введите имя питомца: ");
            name = Console.ReadLine();
            Console.Clear();
            return personage;
        }
        public static void ShowBar(int amounth, string title)
        {
            switch (amounth)
            {
                case 10:
                    Console.WriteLine("                      " + title + ":   |█░░░░░░░░░|");
                    Console.WriteLine();
                    break;
                case 20:
                    Console.WriteLine("                      " + title + ":   |██░░░░░░░░|");
                    Console.WriteLine();
                    break;
                case 30:
                    Console.WriteLine("                      " + title + ":   |███░░░░░░░|");
                    Console.WriteLine();
                    break;
                case 40:
                    Console.WriteLine("                      " + title + ":   |████░░░░░░|");
                    Console.WriteLine();
                    break;
                case 50:
                    Console.WriteLine("                      " + title + ":   |█████░░░░░|");
                    Console.WriteLine();
                    break;
                case 60:
                    Console.WriteLine("                      " + title + ":   |██████░░░░|");
                    Console.WriteLine();
                    break;
                case 70:
                    Console.WriteLine("                      " + title + ":   |███████░░░|");
                    Console.WriteLine();
                    break;
                case 80:
                    Console.WriteLine("                      " + title + ":   |████████░░|");
                    Console.WriteLine();
                    break;
                case 90:
                    Console.WriteLine("                      " + title + ":   |█████████░|");
                    Console.WriteLine();
                    break;
                case 100:
                    Console.WriteLine("                      " + title + ":   |██████████|");
                    Console.WriteLine();
                    break;
            }
        }

        public static void showTama(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("                           ████                ████     ");
                    Console.WriteLine("                         ██    ██            ██    ██    ");
                    Console.WriteLine("                         ██      ██        ██      ██    ");
                    Console.WriteLine("                         ██        ████████        ██    ");
                    Console.WriteLine("                         ██                        ██    ");
                    Console.WriteLine("                       ██      ████        ████      ██  ");
                    Console.WriteLine("                       ██      ██            ██      ██  ");
                    Console.WriteLine("                       ██      ████        ████      ██  ");
                    Console.WriteLine("                       ██            ████            ██  ");
                    Console.WriteLine("                         ████                      ██    ");
                    Console.WriteLine("                           ██                    ██      ");
                    Console.WriteLine("                             ████████████████████        ");
                    Console.WriteLine("       1. Покормить              ██        ██            ");
                    Console.WriteLine("       2. Поиграть             ██          ██            ");
                    Console.WriteLine("       3. Дать таблетку      ██            ██            ");
                    Console.WriteLine("                           ██              ██            ");
                    Console.WriteLine("                           ██      ██    ██              ");
                    Console.WriteLine("                         ██        ██    ██              ");
                    Console.WriteLine("                         ██        ██    ██              ");
                    Console.WriteLine("                         ██        ██    ██              ");
                    Console.WriteLine("                         ██        ██  ██                ");
                    Console.WriteLine("                         ██        ██  ██                ");
                    Console.WriteLine("                       ██          ██  ████              ");
                    Console.WriteLine("                     ██    ██      ████    ██            ");
                    Console.WriteLine("                     ██    ██████████      ██            ");
                    Console.WriteLine("                     ████                ██              ");
                    Console.WriteLine("                         ████████████████ ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("                               ▄▄▀▀▀▀▀▀▀▀▀▄▄");
                    Console.WriteLine("                               █             █");
                    Console.WriteLine("                              █  ▄▄▄     ▄▄▄  █");
                    Console.WriteLine("                              █  ███  ▄  ███  █");
                    Console.WriteLine("                              ▄█ ▄   ▀▀▀   ▄ █▄");
                    Console.WriteLine("      1. Покормить            █  ▀█▀█▀█▀█▀█▀  █");
                    Console.WriteLine("      2. Поиграть             ▄██▄▄▀▀▀▀▀▀▀▄▄██▄");
                    Console.WriteLine("      3. Дать таблетку      ▄█ █▀▀█▀▀▀█▀▀▀█▀▀█ █▄");
                    Console.WriteLine("                           ▄▀ ▄▄▀▄▄▀▀▀▄▀▀▀▄▄▀▄▄ ▀▄");
                    Console.WriteLine("                           █    ▀▄ █▄   ▄█ ▄▀    █");
                    Console.WriteLine("                            ▀▄▄ █  █▄▄▄▄▄█  █ ▄▄▀");
                    Console.WriteLine("                              ▀██▄▄███████▄▄██▀");
                    Console.WriteLine("                              ████████▀████████");
                    Console.WriteLine("                             ▄▄█▀▀▀▀█   █▀▀▀▀█▄▄");
                    Console.WriteLine("                             ▀▄▄▄▄▄▀▀   ▀▀▄▄▄▄▄▀");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("                               ██            ██");
                    Console.WriteLine("                              █  █          █  █");
                    Console.WriteLine("                            ██    █         █   █");
                    Console.WriteLine("                           █   █   █       █    █");
                    Console.WriteLine("                          █    █    █     █    █");
                    Console.WriteLine("                          █   █ █    █   █    █");
                    Console.WriteLine("                          ████   █   █████   █");
                    Console.WriteLine("                                  █         █");
                    Console.WriteLine("                                 █   ▀▀ ▀▀   █");
                    Console.WriteLine("      1. Покормить              █    ██ ██    █");
                    Console.WriteLine("      2. Поиграть               █      █      █");
                    Console.WriteLine("      3. Дать таблетку          █    █   █    █");
                    Console.WriteLine("                                 █    ███    █");
                    Console.WriteLine("                                █████     █████");
                    Console.WriteLine("                          ███  █     █████    █  ███");
                    Console.WriteLine("                         █ █ ██    █       █   ██ █ █");
                    Console.WriteLine("                         █    █     █     █    █    █");
                    Console.WriteLine("                          █    █    █     █   █    █");
                    Console.WriteLine("                           █    ████       ████    █");
                    Console.WriteLine("                            █    █           █    █");
                    Console.WriteLine("                             █    ███     ███    █");
                    Console.WriteLine("                              ████   █████   ████ ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;
            }


            }

        

        public static void ShowGame()
        {
            if(happiness < 1 || health < 1 || satiety < 1)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("            ░░░░░░░░░░░░░▄▐░░░░");
                Console.WriteLine("            ░░░░░░░▄▄▄░░▄██▄░░░");
                Console.WriteLine("            ░░░░░░▐▀█▀▌░░░░▀█▄░");
                Console.WriteLine("            ░░░░░░▐█▄█▌░░░░░░▀█▄");
                Console.WriteLine("            ░░░░░░░▀▄▀░░░▄▄▄▄▄▀▀");
                Console.WriteLine("            ░░░░░▄▄▄██▀▀▀▀░░░░░");
                Console.WriteLine("            ░░░░█▀▄▄▄█░▀▀░░░░░░");
                Console.WriteLine("            ░░░░▌░▄▄▄▐▌▀▀▀░░░░░");
                Console.WriteLine("            ░▄░▐░░░▄▄░█░▀▀░░░░░");
                Console.WriteLine("            ░▀█▌░░░▄░▀█▀░▀░░░░░");
                Console.WriteLine("            ░░░░░░░░▄▄▐▌▄▄░░░░░");
                Console.WriteLine("            ░░░░░░░░▀███▀█░▄░░░");
                Console.WriteLine("            ░░░░░░░▐▌▀▄▀▄▀▐▄░░░");
                Console.WriteLine("            ░░░░░░░▐▀░░░░░░▐▌░░");
                Console.WriteLine("            ░░░░░░░█░░░░░░░░█░░");
                Console.WriteLine("            ░░░░░░▐▌░░░░░░░░░█░");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("   Вы не усмотрели за своим питомцем, он мертв.");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            if (happiness > 101 || health > 101 || satiety > 101)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("            ░░░░░░░░░░░░░▄▐░░░░");
                Console.WriteLine("            ░░░░░░░▄▄▄░░▄██▄░░░");
                Console.WriteLine("            ░░░░░░▐▀█▀▌░░░░▀█▄░");
                Console.WriteLine("            ░░░░░░▐█▄█▌░░░░░░▀█▄");
                Console.WriteLine("            ░░░░░░░▀▄▀░░░▄▄▄▄▄▀▀");
                Console.WriteLine("            ░░░░░▄▄▄██▀▀▀▀░░░░░");
                Console.WriteLine("            ░░░░█▀▄▄▄█░▀▀░░░░░░");
                Console.WriteLine("            ░░░░▌░▄▄▄▐▌▀▀▀░░░░░");
                Console.WriteLine("            ░▄░▐░░░▄▄░█░▀▀░░░░░");
                Console.WriteLine("            ░▀█▌░░░▄░▀█▀░▀░░░░░");
                Console.WriteLine("            ░░░░░░░░▄▄▐▌▄▄░░░░░");
                Console.WriteLine("            ░░░░░░░░▀███▀█░▄░░░");
                Console.WriteLine("            ░░░░░░░▐▌▀▄▀▄▀▐▄░░░");
                Console.WriteLine("            ░░░░░░░▐▀░░░░░░▐▌░░");
                Console.WriteLine("            ░░░░░░░█░░░░░░░░█░░");
                Console.WriteLine("            ░░░░░░▐▌░░░░░░░░░█░");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("   Вы переборщили с опекой, ваш питомец убежал.");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            Console.WriteLine();
            Console.WriteLine("                               Питомец  " + name + "");
            Console.WriteLine();
            showTama(personage);
            ShowBar(health, "Здоровье");
            ShowBar(happiness, "Радость ");
            ShowBar(satiety, "Сытость ");
            rand();

        }

        static void rand()
        {
            Random rand2 = new Random();
            Random rand1 = new Random();
            Random rand = new Random();
            int r1 = rand.Next(0, 4);
            int r2 = rand1.Next(0, 3) * 10;
            int r3 = rand1.Next(0, 3) * 10;
            switch (r1)
            {
                case 1:
                    health= health - r2;
                    break;
                case 2:
                    happiness= happiness - r2;
                    break;
                case 3:
                    satiety=satiety-r2;
                    break;
            }
            int selection = int.Parse(Console.ReadLine());
            switch(selection)
            {
                case 1: satiety=satiety+r3;
                    break;
                case 2:
                    happiness = happiness + r3;
                    break;
                case 3:
                    health = health + r3;
                    break;

            }
            Console.Clear();
            ShowGame();
        }

        static void Main(string[] args)
        {
            SelectPersonage();
            ShowGame();
        }
    }
}
