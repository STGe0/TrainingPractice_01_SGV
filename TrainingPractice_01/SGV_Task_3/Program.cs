using System;

namespace SGV_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "password";
            string attempt_password = "";
            string secret_message = "secret message";
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите пароль: ");
                attempt_password = Console.ReadLine();
                if(attempt_password == password)
                {
                    Console.WriteLine("Секретное сообщение: " + secret_message);
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный пароль!");
                }
            }
            Console.ReadKey();
        }
    }
}
