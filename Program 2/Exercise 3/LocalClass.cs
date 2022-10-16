using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static int GetSumPlusElements(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        public static void PrintPlusElements(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}