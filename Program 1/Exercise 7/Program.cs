using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 0;

            bool check = true;
            while (check)
            {
                Console.Write("Введите первое число: ");
                if (!byte.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (a < 0)
                {
                    Console.WriteLine("Сторона не может быть отрицательной!");
                }
                else if (a > byte.MaxValue)
                {
                    Console.WriteLine("Сторона слишком большая!");
                }
                else
                {
                    check = false;
                }
            }
            check = true;
            byte b = 0;
            while (check)
            {
                Console.Write("Введитет второе число: ");
                if (!byte.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (b < 0)
                {
                    Console.WriteLine("Сторона не может быть отрицательной!");
                }
                else if (b > byte.MaxValue)
                {
                    Console.WriteLine("Сторона слишком большая!");
                }
                else
                {
                    check = false;
                }
            }
            Console.WriteLine($"Побитовое и: {a & b}");
            Console.WriteLine($"Побитовое или: {a | b}");
            Console.WriteLine($"Побитовое ислючающее или: {a ^ b}");
        }
    }
}

