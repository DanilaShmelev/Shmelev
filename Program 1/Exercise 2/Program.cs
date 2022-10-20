using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool check = true;
            while (check)
            {
                Console.Write("Введите количество строк n: ");
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
            for (int i = 0; i < n; i++)
            {
                for (int count = -1; count != i; count++)

                    Console.Write("*");
                Console.Write("\n");

            }
            Console.ReadLine();
        }
    }
}

