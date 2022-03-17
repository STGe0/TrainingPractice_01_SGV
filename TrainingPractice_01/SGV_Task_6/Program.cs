using System;

namespace SGV_Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count_fam = 0, f = 0, menu = 0, _delete = 0, count_dos = 0, post_count = 0;
            bool _while1 = true;
            string name = "", fam = "", otch = "", post_value = "", fam_search = "";
            string[,] fio = new string[1, 3];
            string[] post = new string[1];
            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Отдел кадров");
                        Console.WriteLine("1 - Добавить досье");
                        Console.WriteLine("2 - Вывести все досье");
                        Console.WriteLine("3 - Удалить досье");
                        Console.WriteLine("4 - Поиск досье");
                        Console.WriteLine("5 - Выход из программы");
                        Console.WriteLine();
                        Console.Write("Выберите пункт меню: ");
                        menu = Convert.ToInt32(Console.ReadLine());
                        if (menu > 0 & menu <= 5)
                        {
                            _while1 = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Введите корректное значение");
                            Console.WriteLine();
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Введите корректное значение");
                        Console.WriteLine();
                    }
                } while (_while1);
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Добавление досье");
                        Console.Write("Введите фамилию: ");
                        fam = Console.ReadLine();
                        Console.Write("Введите имя: ");
                        name = Console.ReadLine();
                        Console.Write("Введите отчество: ");
                        otch = Console.ReadLine();
                        Console.Write("Введите должность: ");
                        post_value = Console.ReadLine();
                        AddPost(ref post, post_value, post_count);
                        post_count = post_count + 1;
                        Console.WriteLine("Данные успешно добавлены!");
                        AddMas(ref fio, count_dos, name, fam, otch);
                        count_dos = count_dos + 1;
                        Console.WriteLine("Нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        if(count_dos >= 1)
                        {
                            Console.WriteLine("Вывод всех досье");
                            for (int i = 0; i < count_dos; i++)
                            {
                                Console.Write(i + 1 + "." + " ");
                                for (int j = 0; j < 3; j++)
                                {
                                    Console.Write(fio[i, j] + " ");
                                }
                                Console.WriteLine("- " + post[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Досье не найдено...");
                        }
                        Console.WriteLine("Нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Удалить досье");
                        if(count_dos >= 1)
                        {
                            Console.Write("Введите номер: ");
                            _delete = Convert.ToInt32(Console.ReadLine());
                            RemoveMas(ref fio, _delete, ref count_dos, ref post);
                        }
                        else
                        {
                            Console.WriteLine("Досье не найдено...");
                        }
                        Console.WriteLine("Нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Поиск по фамилии");
                        if (count_dos >= 1)
                        {
                            Console.Write("Введите фамилию: ");
                            fam_search = Console.ReadLine();
                            for(int i = 0; i < fio.GetLength(0); i++)
                            {
                                for(int j = 0; j < 1; j++)
                                {
                                    if(fam_search == fio[i,j])
                                    {
                                        count_fam = count_fam + 1;
                                        Console.WriteLine(count_fam + "." + " " + fio[i, j] + " " + fio[i, j + 1] + " " + fio[i, j + 2] + " " + "-" + " " + post[i]);
                                    }
                                }
                            }
                            if(count_fam > 0)
                            {
                                Console.WriteLine("Количество сотрудников с фамилией {0} - {1}", fam_search, count_fam);
                            }
                            else
                            {
                                if (count_fam == 0)
                                {
                                    Console.WriteLine("Сотрудники с фамилией {0} не найдены.", fam_search);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Досье не найдено...");
                        }
                        count_fam = 0;
                        Console.WriteLine("Нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
        static void AddMas(ref string[,] _fio, int _count_dos, string _name, string _fam, string _otch)
        {
            string[,] newArr = new string[_fio.GetLength(0) + 1, 3];
            newArr[_count_dos, 0] = _fam;
            newArr[_count_dos, 1] = _name;
            newArr[_count_dos, 2] = _otch;
            for(int i = 0; i < _count_dos; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    newArr[i, j] = _fio[i, j];
                }
            }
            _fio = newArr;
        }
        static void AddPost(ref string[] _post, string _post_value, int _post_count)
        {
            string[] newArr = new string[_post.Length + 1];
            newArr[_post_count] = _post_value;
            for(int i = 0; i < _post_count; i++)
            {
                newArr[i] = _post[i];
            }
            _post = newArr;
        }
        static void RemoveMas(ref string[,] _fio, int _delete1, ref int count_dos, ref string[] _post)
        {
            string[,] newArr = new string[_fio.GetLength(0) - 1, 3];
            for(int i = 0; i < _delete1 - 1; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    newArr[i, j] = _fio[i, j];
                }
            }
            for (int i = _delete1; i < _fio.GetLength(0) - 1; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    newArr[i - 1, j] = _fio[i, j];
                }
            }
            _fio = newArr;

            string[] newArr2 = new string[_post.Length + 1];
            for(int i = 0; i < _delete1 - 1; i++)
            {
                newArr2[i] = _post[i];
            }
            for(int i = _delete1; i < _post.Length - 1; i++)
            {
                newArr2[i - 1] = _post[i];
            }
            _post = newArr2;
            count_dos = count_dos - 1;
        }
    }
}
