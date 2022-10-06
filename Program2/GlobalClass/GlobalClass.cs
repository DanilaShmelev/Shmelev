using System;

namespace Global_Class
{
    public static class GlobalClass
    {
        public static int[] GetRandomArray(int minValue, int maxValue, int arrayelements)
        {
            Random random = new Random(); 

            int[] array = new int[arrayelements];

            for (int i = 0; i < arrayelements; i++)
            {
                array[i] = random.Next(minValue, maxValue); 
            }

            return array;
        }

        public static void OutputArray (int[] array)
        {
            for (int i = 0;i < array.Length;i++)
            {
                Console.Write(array[i] +" ");
            }
        }


        public static int[] setArray(int[] array)
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