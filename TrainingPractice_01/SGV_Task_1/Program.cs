using System;

namespace SGV_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int balance_gold = 0;
            int balance_crystals = 0;
            int count_crystals = 0;
            int count_available_crystals = 0;
            int summa_sdelki = 0;
            bool _while1 = true;
            bool _while2 = true;
            bool _while3 = false;
            bool _while4 = false;
            bool _while11 = true;
            do
            {
                try
                {
                    Console.Clear();
                    Console.Write("Введите начальное количество золота: ");
                    balance_gold = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    balance_gold = 0;
                }
            } 
            while (balance_gold <= 0);
            int price_crystal = random.Next(1, 100);
            Console.WriteLine("-----------------------------------------------------------------------");
            count_available_crystals = balance_gold / price_crystal;
            while (count_available_crystals != 0 & _while1)
            {
                Console.WriteLine("-----Баланс: Золото: {0}, Кристаллы: {1}-----", balance_gold, balance_crystals);
                Console.WriteLine("-Продавец: \"Сколько ед. кристаллов Вы хотите купить? Цена за ед. кристалла: {0}\"", price_crystal);
                do
                {
                    try
                    {
                        Console.Write("-----Введите количество ед. кристаллов, которые Вы хотите купить----- ");
                        count_crystals = Convert.ToInt32(Console.ReadLine());
                        summa_sdelki = count_crystals * price_crystal;
                    }
                    catch
                    {
                        count_crystals = 0;
                    }
                }
                while (count_crystals <= 0);
                _while1 = false;
                _while3 = true;
                while (summa_sdelki > balance_gold & _while11)
                {
                    _while4 = true;
                    _while11 = false;
                    _while3 = false;
                }
            }
            while (count_available_crystals == 0 && _while2)
            {
                Console.WriteLine("- Продавец: \"Извини, дружище, эти кристаллы тебе не по карману :(. Повезет в следующий раз. До встречи!\"");
                _while2 = false;
            }
            while (_while3)
            {
                Console.WriteLine("- Я: \"Продавец, а дай мне {0} ед. кристалла!\"", count_crystals);
                Console.WriteLine("- Продавец: \"Хорошо, с тебя {0} золота. До встречи!\"", summa_sdelki);
                balance_gold = balance_gold - summa_sdelki;
                balance_crystals = balance_crystals + count_crystals;
                Console.WriteLine("-----Баланс: Золото: {0}, Кристаллы: {1}-----", balance_gold, balance_crystals);
                _while3 = false;
            }
            while (_while4)
            {
                Console.WriteLine("- Продавец: \"Извини, дружище, у тебя нет такого количества золота для совершениея сделки. Повезет в следующий раз. До встречи!\"");
                _while4 = false;
            }
            Console.ReadKey();
        }
    }
}
