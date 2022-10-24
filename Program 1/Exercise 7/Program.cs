using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte firstNumber = 0;

            bool check = true;
            while (check)
            {
                Console.Write("Введите первое число: ");
                if (!byte.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (firstNumber < 0)
                {
                    Console.WriteLine("Сторона не может быть отрицательной!");
                }
                else if (firstNumber > byte.MaxValue)
                {
                    Console.WriteLine("Сторона слишком большая!");
                }
                else
                {
                    check = false;
                }
            }
            check = true;
            byte secondNumber = 0;
            while (check)
            {
                Console.Write("Введитет второе число: ");
                if (!byte.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (secondNumber < 0)
                {
                    Console.WriteLine("Сторона не может быть отрицательной!");
                }
                else if (secondNumber > byte.MaxValue)
                {
                    Console.WriteLine("Сторона слишком большая!");
                }
                else
                {
                    check = false;
                }
            }
            Console.WriteLine($"Побитовое и: {firstNumber & secondNumber}");
            Console.WriteLine($"Побитовое или: {firstNumber | secondNumber}");
            Console.WriteLine($"Побитовое ислючающее или: {firstNumber ^ secondNumber}");
        }
    }
}

