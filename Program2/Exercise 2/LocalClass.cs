using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static int[,,] GetThreeArray(int minValue, int maxValue, int a, int b, int c)
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

        public static void OutPutArray(int[,,] array, int a, int b, int c)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < b; j++)
                {
                    Console.Write("\n");
                    for (int k = 0; k < c; k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                }
            }
        }

        public static void ChangeArray(int[,,] array, int a, int b, int c)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k= 0; k < c; k++)
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