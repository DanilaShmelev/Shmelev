using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstSide = 0;
            bool check = true;
            while (check)
            {
                Console.Write("Введите первую сторону треугольника: ");
                if (!double.TryParse(Console.ReadLine(), out firstSide))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (firstSide < 1)
                {
                    Console.WriteLine("Вы ввели значение меньше 1!");
                }
                else if (firstSide > double.MaxValue)
                {
                    Console.WriteLine("Число слишком большое!");
                }
                else
                {
                    check = false;
                }
            }
            check = true;
            double secondSide = 0;
            while (check)
            {
                Console.Write("Введите вторую сторону треугольника: ");
                if (!double.TryParse(Console.ReadLine(), out secondSide))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (secondSide < 1)
                {
                    Console.WriteLine("Вы ввели значение меньше 1!");
                }
                else if (secondSide > double.MaxValue)
                {
                    Console.WriteLine("Число слишком большое!");
                }
                else
                {
                    check = false;
                }
            }
            check = true;
            double thirdSide = 0;
            while (check)
            {
                Console.Write("Введите третью сторону треугольника: ");
                if (!double.TryParse(Console.ReadLine(), out thirdSide))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (thirdSide < 1)
                {
                    Console.WriteLine("Вы ввели значение меньше 1!");
                }
                else if (thirdSide > double.MaxValue)
                {
                    Console.WriteLine("Число слишком большое!");
                }
                else
                {
                    check = false;
                }
            }
            if (firstSide + secondSide < thirdSide || firstSide + thirdSide < secondSide || secondSide + thirdSide < firstSide)
            {
                Console.WriteLine("Треугольника с данными сторонами не существует!!!");
            }
            else
            {
                double SemiPerimeter = (firstSide + secondSide + thirdSide) / 2;
                double square = Math.Sqrt(SemiPerimeter * (SemiPerimeter - firstSide) * (SemiPerimeter - secondSide) * (SemiPerimeter - thirdSide));
                Console.WriteLine("Полупериметр = " + SemiPerimeter + "\nПлощадь = " + square);
                Console.ReadKey();
            }
        }
    }
}