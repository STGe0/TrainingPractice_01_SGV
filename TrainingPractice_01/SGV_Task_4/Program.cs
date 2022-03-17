using System;
using System.Collections.Generic;

namespace SGV_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int boss_health = 1500; 
            int player_health = 1000; 
            int first_turn = rnd.Next(1, 20);
            int turn = 1;
            bool _while1 = true;
            bool _while2 = true;
            int cast = 0;
            int cast_boss = 0;
            var cast_player_name = new List<string>()
            {
                "Руна огня (Взрывается, нанося урон горением 25 ед. HP в секунду (всего 3 тика))",
                "Поднять щиты (Заклинание поддержки, поднимает HP героя на 200 ед.)",
                "Заморозка (Наносит льдом 100 ед. урона)",
                "Огненный взрыв (Наносит огнем 100 ед. урона, а также в течение 3 секунд накладывается эффект \"Горение\" (25 ед. урона))",
                "Ядовитый дротик (Наносит 150 ед. урона, а также накладывает эффект \"Яд\" (50 ед. урона единовременно))"
            };
            var cast_boss_name = new List<string>()
            {
                "Звездная пыль (Вызывает эффект падения звезды и наносит 125 ед. урона)",
                "Толстая шкура (Заклинание поддержки, поднимает HP босса на 200 ед.)",
                "Кувалда (Босс наносит своей кувалдой 100 ед. урона)",
                "Плеть (Босс при помощи темной магии наносит 150 ед. урона + вызывает эффект \"Некропламя\" (50 ед. урона в течение 2 секунд))",
                "Пожирание (Босс выбрасывает ядовитую массу на героя, накладывается эффект \"Яд\" (-25 HP единовременно))"
            };
            if (first_turn >= 1 & first_turn <= 10)
            {
                Console.WriteLine("----------Первый ход за игроком.----------");
            }
            else
            {
                if (first_turn >= 11 & first_turn <= 20)
                {
                    Console.WriteLine("----------Первый ход за боссом.----------");
                }    
            }
            while(_while1)
            {
                if (boss_health <= 0)
                {
                    Console.WriteLine("----------Босс повержен, Вы победили!----------");
                    _while1 = false;
                    Environment.Exit(0);
                }
                else
                {
                    if (player_health <= 0)
                    {
                        Console.WriteLine("----------Вы повержены, Босс победил!----------");
                        _while1 = false;
                        Environment.Exit(0);

                    }
                }
                Console.WriteLine("------------------Ход {0}--------------------", turn);
                turn++;
                _while2 = true;
                if (first_turn >= 1 & first_turn <= 10)
                {
                    if (first_turn >= 1 & first_turn <= 10)
                    {
                        Console.WriteLine("---------Ход Игрока. Выберите заклинание----------");
                        foreach (var item in cast_player_name)
                        {
                            switch (item)
                            {
                                case "Руна огня (Взрывается, нанося урон горением 25 ед. HP в секунду (всего 3 тика))":
                                    Console.WriteLine(item);
                                    break;
                                case "Поднять щиты (Заклинание поддержки, поднимает HP героя на 200 ед.)":
                                    Console.WriteLine(item);
                                    break;
                                case "Заморозка (Наносит льдом 100 ед. урона)":
                                    Console.WriteLine(item);
                                    break;
                                case "Огненный взрыв (Наносит огнем 100 ед. урона, а также в течение 3 секунд накладывается эффект \"Горение\" (25 ед. урона))":
                                    Console.WriteLine(item);
                                    break;
                                case "Ядовитый дротик (Наносит 150 ед. урона, а также накладывает эффект \"Яд\" (50 ед. урона единовременно))":
                                    Console.WriteLine(item);
                                    break;
                            }
                        }
                            do
                            {
                            try
                            {
                                cast = Convert.ToInt32(Console.ReadLine());
                                if (cast >= 1 & cast <= 5)
                                {
                                    switch (cast)
                                    {
                                        case 1:
                                            Console.WriteLine("Руна огня (Взрывается, нанося урон горением 25 ед. HP в секунду (всего 3 тика))");
                                            Console.WriteLine("HP Boss: " + boss_health);
                                            for (int i = 0; i < 3; i++)
                                            {
                                                boss_health = boss_health - 25;
                                                Console.WriteLine("Действие поджога... HP Boss: " + boss_health);
                                            }
                                            break;
                                        case 2:
                                            Console.WriteLine("Поднять щиты (Заклинание поддержки, поднимает HP героя на 200 ед.)");
                                            player_health = player_health + 200;
                                            Console.WriteLine("Поднятие брони... HP Player: " + player_health);
                                            break;
                                        case 3:
                                            Console.WriteLine("Заморозка (Наносит льдом 100 ед. урона)");
                                            boss_health = boss_health - 100;
                                            Console.WriteLine("HP Boss: " + boss_health);
                                            break;
                                        case 4:
                                            Console.WriteLine("Огненный взрыв (Наносит огнем 100 ед. урона, а также в течение 3 секунд накладывается эффект \"Горение\" (25 ед. урона))");
                                            boss_health = boss_health - 100;
                                            Console.WriteLine("HP Boss: " + boss_health);
                                            for (int i = 0; i < 3; i++)
                                            {
                                                boss_health = boss_health - 25;
                                                Console.WriteLine("Действие поджога... HP Boss: " + boss_health);
                                            }
                                            break;
                                        case 5:
                                            Console.WriteLine("Ядовитый дротик (Наносит 150 ед. урона, а также накладывает эффект \"Яд\" (50 ед. урона единовременно))");
                                            boss_health = boss_health - 150;
                                            Console.WriteLine("HP Boss: " + boss_health);
                                            boss_health = boss_health - 50;
                                            Console.WriteLine("Действие яда... HP Boss: " + boss_health);
                                            break;
                                    }
                                    _while2 = false;
                                }
                                else
                                {
                                    if(cast <= 0 || cast > 5)
                                    {
                                        _while2 = true;
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Введите корректное значение!");
                            }
                            }  
                            while (_while2);
                        first_turn += 10;
                    }
                    if (first_turn >= 11 & first_turn <= 20)
                    {
                        Console.WriteLine("---------------Ход Босса-------------");
                        cast_boss = rnd.Next(1, 5);
                        switch (cast_boss)
                        {
                            case 1:
                                Console.WriteLine("Звездная пыль (Вызывает эффект падения звезды и наносит 125 ед. урона)");
                                player_health = player_health - 125;
                                Console.WriteLine("HP Player: " + player_health);
                                break;
                            case 2:
                                Console.WriteLine("Толстая шкура (Заклинание поддержки, поднимает HP босса на 200 ед.)");
                                boss_health = boss_health + 200;
                                Console.WriteLine("Поднятие брони... HP Boss: " + boss_health);
                                break;
                            case 3:
                                Console.WriteLine("Кувалда (Босс наносит своей кувалдой 100 ед. урона)");
                                player_health = player_health - 100;
                                Console.WriteLine("HP Player: " + player_health);
                                break;
                            case 4:
                                Console.WriteLine("Плеть (Босс при помощи темной магии наносит 150 ед. урона + вызывает эффект \"Некропламя\" (50 ед. урона в течение 2 секунд))");
                                player_health = player_health - 150;
                                Console.WriteLine("HP Player: " + player_health);
                                for(int i = 0; i < 2; i++)
                                {
                                    player_health = player_health - 50;
                                    Console.WriteLine("Некропламя! -50 ед. HP! HP Player:"  + player_health);
                                }
                                break;
                            case 5:
                                Console.WriteLine("Пожирание (Босс выбрасывает ядовитую массу на героя, накладывается эффект \"Яд\" (-25 HP единовременно))");
                                player_health = player_health - 100;
                                Console.WriteLine("HP Player: " + player_health);
                                player_health = player_health - 25;
                                Console.WriteLine("Действие яда... HP Player: " + player_health);
                                break;
                        }
                        first_turn -= 10;
                    }
                }
                if (first_turn >= 11 & first_turn <= 20)
                {
                    if (first_turn >= 11 & first_turn <= 20)
                    {
                        Console.WriteLine("---------------Ход Босса-------------");
                        cast_boss = rnd.Next(1, 5);
                        switch (cast_boss)
                        {
                            case 1:
                                Console.WriteLine("Звездная пыль (Вызывает эффект падения звезды и наносит 125 ед. урона)");
                                player_health = player_health - 125;
                                Console.WriteLine("HP Player: " + player_health);
                                break;
                            case 2:
                                Console.WriteLine("Толстая шкура (Заклинание поддержки, поднимает HP босса на 200 ед.)");
                                boss_health = boss_health + 200;
                                Console.WriteLine("Поднятие брони... HP Boss: " + boss_health);
                                break;
                            case 3:
                                Console.WriteLine("Кувалда (Босс наносит своей кувалдой 100 ед. урона)");
                                player_health = player_health - 100;
                                Console.WriteLine("HP Player: " + player_health);
                                break;
                            case 4:
                                Console.WriteLine("Плеть (Босс при помощи темной магии наносит 150 ед. урона + вызывает эффект \"Некропламя\" (50 ед. урона в течение 2 секунд))");
                                player_health = player_health - 150;
                                Console.WriteLine("HP Player: " + player_health);
                                for (int i = 0; i < 2; i++)
                                {
                                    player_health = player_health - 50;
                                    Console.WriteLine("Некропламя! -50 ед. HP! HP Player:" + player_health);
                                }
                                break;
                            case 5:
                                Console.WriteLine("Пожирание (Босс выбрасывает ядовитую массу на героя, накладывается эффект \"Яд\" (-25 HP единовременно))");
                                player_health = player_health - 100;
                                Console.WriteLine("HP Player: " + player_health);
                                player_health = player_health - 25;
                                Console.WriteLine("Действие яда... HP Player: " + player_health);
                                break;
                        }
                        first_turn -= 10;
                    }
                    if (first_turn >= 1 & first_turn <= 10)
                    {
                        Console.WriteLine("---------Ход Игрока. Выберите заклинание----------");
                        foreach (var item in cast_player_name)
                        {
                            switch (item)
                            {
                                case "Руна огня (Взрывается, нанося урон горением 25 ед. HP в секунду (всего 3 тика))":
                                    Console.WriteLine(item);
                                    break;
                                case "Поднять щиты (Заклинание поддержки, поднимает HP героя на 200 ед.)":
                                    Console.WriteLine(item);
                                    break;
                                case "Заморозка (Наносит льдом 100 ед. урона)":
                                    Console.WriteLine(item);
                                    break;
                                case "Огненный взрыв (Наносит огнем 100 ед. урона, а также в течение 3 секунд накладывается эффект \"Горение\" (25 ед. урона))":
                                    Console.WriteLine(item);
                                    break;
                                case "Ядовитый дротик (Наносит 150 ед. урона, а также накладывает эффект \"Яд\" (50 ед. урона единовременно))":
                                    Console.WriteLine(item);
                                    break;
                            }
                        }
                        do
                        {
                            try
                            {
                                cast = Convert.ToInt32(Console.ReadLine());
                                if (cast >= 1 & cast <= 5)
                                {
                                    switch (cast)
                                    {
                                        case 1:
                                            Console.WriteLine("Руна огня (Взрывается, нанося урон горением 25 ед. HP в секунду (всего 3 тика))");
                                            Console.WriteLine("HP Boss: " + boss_health);
                                            for (int i = 0; i < 3; i++)
                                            {
                                                boss_health = boss_health - 25;
                                                Console.WriteLine("Действие поджога... HP Boss: " + boss_health);
                                            }
                                            break;
                                        case 2:
                                            Console.WriteLine("Поднять щиты (Заклинание поддержки, поднимает HP героя на 200 ед.)");
                                            player_health = player_health + 200;
                                            Console.WriteLine("Поднятие брони... HP Player: " + player_health);
                                            break;
                                        case 3:
                                            Console.WriteLine("Заморозка (Наносит льдом 100 ед. урона)");
                                            boss_health = boss_health - 100;
                                            Console.WriteLine("HP Boss: " + boss_health);
                                            break;
                                        case 4:
                                            Console.WriteLine("Огненный взрыв (Наносит огнем 100 ед. урона, а также в течение 3 секунд накладывается эффект \"Горение\" (25 ед. урона))");
                                            boss_health = boss_health - 100;
                                            Console.WriteLine("HP Boss: " + boss_health);
                                            for (int i = 0; i < 3; i++)
                                            {
                                                boss_health = boss_health - 25;
                                                Console.WriteLine("Действие поджога... HP Boss: " + boss_health);
                                            }
                                            break;
                                        case 5:
                                            Console.WriteLine("Ядовитый дротик (Наносит 150 ед. урона, а также накладывает эффект \"Яд\" (50 ед. урона единовременно))");
                                            boss_health = boss_health - 150;
                                            Console.WriteLine("HP Boss: " + boss_health);
                                            boss_health = boss_health - 50;
                                            Console.WriteLine("Действие яда... HP Boss: " + boss_health);
                                            break;
                                    }
                                    _while2 = false;
                                }
                                else
                                {
                                    if (cast <= 0 || cast > 5)
                                    {
                                        _while2 = true;
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Введите корректное значение!");
                            }
                        }
                        while (_while2);
                        first_turn += 10;
                    }
                }    
            }
        }
    }
}
