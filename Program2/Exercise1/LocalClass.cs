using System;


namespace Local_Class
{
    public static class LocalClass
    {
        public static int getMaxValue(int[] array)
        {
            int max = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int getMinValue(int[] array)
        {
            int min = int.MinValue;

            for (int i = 0; i< array.Length; i++)
            {
                if(array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static void SortArray(int[] array)
        {
            int temp;

            for (int i = 0; i <array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
