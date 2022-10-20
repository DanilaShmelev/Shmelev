using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int a = 0;
            int n = 0;
            bool check = true;
            while (check)
            {
                Console.Write("Введите число n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (n < 1)
                {
                    Console.WriteLine("Вы ввели значение меньше 1!");
                }
                else if (n > int.MaxValue)
                {
                    Console.WriteLine("Число слишком большое!");
                }
                else
                {
                    check = false;
                }
            }
            while (a < n)
            {
                if ((a % 3 == 0) || (a % 5 == 0))
                {
                    result += a;
                }
                a++;
            }
            Console.WriteLine("Сумма чисел кратных 3 или 5 = " + result);
            Console.ReadLine();
        }
    }
}

