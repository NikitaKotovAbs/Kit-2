string answer;
string yes = "да";
do
{ 
    Console.WriteLine("1 — Игра угадай число\n2 — Таблица умножения\n3 — Вывод делителей числа\n4 — Выйти из программы\nВыберите опперацию :");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a == 4)
    {
        Console.WriteLine("Вы вышли из программы");
        return;
    }
    if (a == 1)
        {
            Random random = new Random();
            int n = random.Next(0, 100) + 1;
            string chislo;
            Console.WriteLine("Угадайте число от 1 до 100");
            do
            {
                Console.Write("Ваш вариант: ");
                chislo = Console.ReadLine();

                if (int.Parse(chislo) < n)
                    Console.WriteLine("Задуманное число больше");
                if (int.Parse(chislo) > n)
                    Console.WriteLine("Задуманное число меньше");
            }
            while (int.Parse(chislo) != n);
            Console.WriteLine("Вы угадали");
    }
        if (a == 2)
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
        if (a == 3)
        {
            Console.Write("Введи число ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.Write("\n"+ i);
                }
            }
        }
        Console.WriteLine("\nВернуться к программам? (да/нет) ");
        answer = Console.ReadLine();
} while (answer.Equals(yes, StringComparison.OrdinalIgnoreCase));