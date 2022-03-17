using System;

namespace SGV_Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool _while1 = true;
            Random rnd = new Random();
            do
            {
                try
                {
                    Console.Write("Введите количество элементов в одномерном массиве: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if(n > 0)
                    {
                        _while1 = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Неккоректный формат!");
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Неккоректный формат!");
                }
            } while (_while1);
            int[] mas = new int[n];
            Console.Write("Первоначальный вид массива: ");
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(1, 100);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            Shuffle_Fisher_Yetc(ref mas, rnd);
            Console.Write("Перемешанный массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        //Алгоритм Фишера — Йетса. 
        static void Shuffle_Fisher_Yetc(ref int[] arr, Random _rnd)
        {
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = _rnd.Next(i + 1);

                int tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }
    }
}
