using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstSide = 0;

            bool check = true;
            while (check)
            {
                Console.WriteLine("Введитет первую сторону прямоугольника а: ");
                if (!float.TryParse(Console.ReadLine(), out firstSide))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (firstSide < 0)
                {
                    Console.WriteLine("Сторона не может быть отрицательной!");
                }
                else if (firstSide > float.MaxValue)
                {
                    Console.WriteLine("Сторона слишком большая!");
                }
                else
                {
                    check = false;
                }
            }
            check = true;
            float secondSide = 0;
            while (check)
            {
                Console.WriteLine("Введитет вторую сторону прямоугольника b: ");
                if (!float.TryParse(Console.ReadLine(), out secondSide))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (secondSide < 0)
                {
                    Console.WriteLine("Сторона не может быть отрицательной!");
                }
                else if (secondSide > float.MaxValue)
                {
                    Console.WriteLine("Сторона слишком большая!");
                }
                else
                {
                    check = false;
                }
            }
            float result = firstSide * secondSide;
            if (firstSide == secondSide)
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

