using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static int[,,] GetRandomThreeArray(int minValue, int maxValue, int a, int b, int c)
        {
            Random random = new Random(); 

            int[,,] array = new int[a, b, c];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        array[i, j, k] = random.Next(minValue, maxValue);
                    }
                }
            }

            return array;
        }

        public static void OutputArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("\n");
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                }
            }
        }

        public static void ReplacePlusElements(int[,,] array)
        {
            for (int i = 0; i <   array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
        }
    }
}