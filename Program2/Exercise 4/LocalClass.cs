using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static int[,] GetTwoArray(int minValue, int maxValue, int a, int b)
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

        public static void OutPutArray(int[,] array, int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < b; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
        }

        public static int GetSumEvenPosition(int[,] numbers, int a, int b)
        {
            int sum = 0;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += numbers[i, j];
                    }
                }
            }

            return sum;
        }
    }
}