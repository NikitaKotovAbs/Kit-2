namespace Ubisoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tДля запуска программы введите число\n\tЕсли вы хотите использовать одну функцию программы и выйти из неё, введите число 4 =3");
            int a = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("\n1 — Игра угадай число\n2 — Таблица умножения\n3 — Вывод делителей числа\n4 — Выйти из программы\nВыберите опперацию :");
                int d = Convert.ToInt32(Console.ReadLine());
                if (d == 1)
                {
                    One();
                }
                if (d == 2)
                {
                    Two();
                }
                if (d == 3)
                {
                    Three();
                }
                if (d == 4)
                {
                    Exit();
                    break;
                }
            } while (a != 4);
        }
        static void One() 
        {
            Random random = new Random();
            int n = random.Next(0, 100) + 1;
            string number;
            Console.WriteLine("Угадайте число от 1 до 100");
            do
            {
                Console.Write("Ваш вариант: ");
                number = Console.ReadLine();

                if (int.Parse(number) < n)
                    Console.WriteLine("Задуманное число больше");
                if (int.Parse(number) > n)
                    Console.WriteLine("Задуманное число меньше");
            }
            while (int.Parse(number) != n);
            Console.WriteLine("Вы угадали");
        }
        static void Two()
        {
            Console.WriteLine("Таблица умножения");
            int x = 10;
            int y = 10;
            int[,] mat = new int[x, y];
            for (int i = 1; i < y; i++)
            {
                Console.WriteLine("");
                for (int k = 1; k < x; k++)
                {
                    Console.Write("\t" + i * k);
                }
                Console.WriteLine("\t");

            }
        }
        static void Three()
        {
            Console.Write("Введи число ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.Write("\n" + i);
                }
            }
        }
        static void Exit()
        {
            Console.WriteLine("Введите любое число(желатиельно 100 и выше :3)");
            int ff = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < ff; i++)
            {
                Console.WriteLine("\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\t\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                Console.WriteLine("\tВы вышли из программы, наслаждайтесь:3");
                Thread.Sleep(10);
                
            }
            
        }
        



    }
}
/*using System;
using System.Threading;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] TheFirstAction)
        {
            Console.WriteLine("\t\t\t\tДля запуска программы введите число\n\tЕсли вы хотите использовать одну функцию программы и выйти из неё, введите число 4 =3");
            int a = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("\n1 — Игра угадай число\n2 — Таблица умножения\n3 — Вывод делителей числа\n4 — Выйти из программы\nВыберите опперацию :");
                int d = Convert.ToInt32(Console.ReadLine());
                if (d == 1)
                {
                    One();
                }
                if (d == 2)
                {
                    Two();
                    if (d == 3)
                    {
                        Three();
                    }
                    if (d == 4)
                    {
                        exit();
                        break;
                    }

                    while (a != 4) ;






                }

                static void One()
                {


                    Random random = new Random();
                    int n = random.Next(0, 100) + 1;
                    string number;
                    Console.WriteLine("Угадайте число от 1 до 100");
                    do
                    {
                        Console.Write("Ваш вариант: ");
                        number = Console.ReadLine();

                        if (int.Parse(number) < n)
                            Console.WriteLine("Задуманное число больше");
                        if (int.Parse(number) > n)
                            Console.WriteLine("Задуманное число меньше");
                    }
                    while (int.Parse(number) != n);
                    Console.WriteLine("Вы угадали");

                }

                static void Two()
                {
                    Console.WriteLine("Таблица умножения");
                    int x = 10;
                    int y = 10;
                    int[,] mat = new int[x, y];
                    for (int i = 1; i < y; i++)
                    {
                        Console.WriteLine("");
                        for (int k = 1; k < x; k++)
                        {
                            Console.Write("\t" + i * k);
                        }
                        Console.WriteLine("\t");

                    }

                }
                static void Three()
                {
                    Console.Write("Введи число ");
                    int x = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= x; i++)
                    {
                        if (x % i == 0)
                        {
                            Console.Write("\n" + i);
                        }
                    }

                }
                static void exit()
                {
                    Console.WriteLine("Введите любое число(желатиельно 100 и выше :3)");
                    int ff = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i < ff; i++)
                    {
                        Console.WriteLine("\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\t\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\t\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                        Console.WriteLine("\tВы вышли из программы, наслаждайтесь:3");
                        Thread.Sleep(10);
                    }
                    return;
                }

            }
}*/