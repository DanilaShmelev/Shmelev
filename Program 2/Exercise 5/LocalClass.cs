using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static int[] GetPlusArray(int[] first_array)
        {
            int size = 0;

            for (int i = 0; i < first_array.Length; i++)
            {
                if (first_array[i] > 0)
                {
                    size++;
                }
            }
            

            int[] second_array = new int[size];

            int index = 0;

            for (int i = 0; i < first_array.Length; i++)
            {
                if (first_array[i] > 0)
                {
                    second_array[index] = first_array[i];
                    index++;
                }
            }
            return second_array;
        }
    }
}