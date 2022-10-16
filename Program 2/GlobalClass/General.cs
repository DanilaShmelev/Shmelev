using System;

namespace General
{
    public static class GlobalClass
    {
        public static int[] GetRandomArray(int minValue, int maxValue, int arrayLength)
        {
            Random random = new Random(); 

            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(minValue, maxValue); 
            }

            return array;
        }

        public static void OutPutArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static int SetArraySize()
        {
            int n = 0;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("На вход принимаются только int значения");
                }
                else if (n < 1)
                {
                    Console.WriteLine("Массив не может быть меньше единицы");
                }
                else
                {
                    break;
                }
            }

            return n;
        }

        public static int[] SetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int element = 0;
                while (true)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    if (!int.TryParse(Console.ReadLine(), out element))
                    {
                        Console.WriteLine("На вход принимаются только int значения");
                        continue;
                    }
                    array[i] = element;
                    break;
                }
            }

            return array;
        }
    }
}