using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static int[,] GetDoubleRandomArray(int minValue, int maxValue, int a, int b)
        {
            int[,] array = new int[a, b];

            Random random = new Random();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }

            return array;
        }

        public static void OutputArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
        }

        public static int GetResultMultiplesPosition(int[,] array)
        {
            int result = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        result += array[i, j];
                    }
                }
            }

            return result;
        }
    }
}