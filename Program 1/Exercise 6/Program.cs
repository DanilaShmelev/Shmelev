using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            bool check = true;
            while (check)
            {
                Console.Write("Введите первую сторону треугольника: ");
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (a < 1)
                {
                    Console.WriteLine("Вы ввели значение меньше 1!");
                }
                else if (a > double.MaxValue)
                {
                    Console.WriteLine("Число слишком большое!");
                }
                else
                {
                    check = false;
                }
            }
            check = true;
            double b = 0;
            while (check)
            {
                Console.Write("Введите вторую сторону треугольника: ");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (b < 1)
                {
                    Console.WriteLine("Вы ввели значение меньше 1!");
                }
                else if (b > double.MaxValue)
                {
                    Console.WriteLine("Число слишком большое!");
                }
                else
                {
                    check = false;
                }
            }
            check = true;
            double c = 0;
            while (check)
            {
                Console.Write("Введите третью сторону треугольника: ");
                if (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (c < 1)
                {
                    Console.WriteLine("Вы ввели значение меньше 1!");
                }
                else if (c > double.MaxValue)
                {
                    Console.WriteLine("Число слишком большое!");
                }
                else
                {
                    check = false;
                }
            }
            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Треугольника с данными сторонами не существует!!!");
            }
            else
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Полупериметр = " + p + "\nПлощадь = " + s);
                Console.ReadKey();
            }
        }
    }
}