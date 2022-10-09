using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static int[] DoubleMinusElements(int[] array)
        {
            int size = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    size++;
                }
            }

            int[]DoubleArray = new int[array.Length + size];

            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    DoubleArray[index] = array[i];
                    DoubleArray[index + 1] = array[i];
                    index++;
                }
                else
                {
                    DoubleArray[index] = array[i];
                }
                index++;
            }

            return DoubleArray;
        }
    }
}