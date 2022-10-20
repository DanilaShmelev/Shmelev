using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0;

            bool check = true;
            while (check)
            {
                Console.WriteLine("Введитет первую сторону прямоугольника а: ");
                if (!float.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (a < 0)
                {
                    Console.WriteLine("Сторона не может быть отрицательной!");
                }
                else if (a > float.MaxValue)
                {
                    Console.WriteLine("Сторона слишком большая!");
                }
                else
                {
                    check = false;
                }
            }
            check = true;
            float b = 0;
            while (check)
            {
                Console.WriteLine("Введитет вторую сторону прямоугольника b: ");
                if (!float.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (b < 0)
                {
                    Console.WriteLine("Сторона не может быть отрицательной!");
                }
                else if (b > float.MaxValue)
                {
                    Console.WriteLine("Сторона слишком большая!");
                }
                else
                {
                    check = false;
                }
            }
            float result = a * b;
            if (a == b)
            {
                Console.WriteLine("Прямоугольник является квадратом!!!");
                Console.WriteLine($"Площадь квадрата равна:{result}");
                Environment.Exit(0);
            }
            Console.WriteLine($"Площадь прямоугольника равна: {result}");
            Console.ReadKey();
        }
    }
}

