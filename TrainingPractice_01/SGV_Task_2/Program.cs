using System;

namespace SGV_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string str = "";
            do
            {
                Console.WriteLine("Заполнение шкалы...{0}%. Для остановки напишите кодовое слово \"exit\"", i);
                i++;
                str = Console.ReadLine();
            }
            while (str != "exit");
            Console.WriteLine("Поздравляем, Вы остановили шкалу на {0}%!", i - 1);
            Console.ReadKey();
        }
    }
}