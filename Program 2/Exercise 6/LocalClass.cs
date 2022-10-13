using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static int[] DoubleMinusElements(int[] first_array)
        {
            int size = 0;

            for (int i = 0; i < first_array.Length; i++)
            {
                if (first_array[i] < 0)
                {
                    size++;
                }
            }

            int[] second_array = new int[first_array.Length + size];

            int index = 0;

            for (int i = 0; i < first_array.Length; i++)
            {
                if (first_array[i] < 0)
                {
                    second_array[index] = first_array[i];
                    second_array[index + 1] = first_array[i];
                    index++;
                }
                else
                {
                    second_array[index] = first_array[i];
                }
                index++;
            }

            return second_array;
        }
    }
}