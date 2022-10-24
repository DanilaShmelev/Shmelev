using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int tempNumber = 0;
            int Number = 0;
            bool check = true;
            while (check)
            {
                Console.Write("Введите число Number: ");
                if (!int.TryParse(Console.ReadLine(), out Number))
                {
                    Console.WriteLine("Вы ввели число не верного типа данных!!!");
                }
                else if (Number < 1)
                {
                    Console.WriteLine("Вы ввели значение меньше 1!");
                }
                else if (Number > int.MaxValue)
                {
                    Console.WriteLine("Число слишком большое!");
                }
                else
                {
                    check = false;
                }
            }
            while (tempNumber < Number)
            {
                if ((tempNumber % 3 == 0) || (tempNumber % 5 == 0))
                {
                    result += tempNumber;
                }
                tempNumber++;
            }
            Console.WriteLine("Сумма чисел кратных 3 или 5 = " + result);
            Console.ReadLine();
        }
    }
}

