using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static int[] DeleteMinusElements(int[] array)
        {
            int size = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    size++;
                }
            }

            int[] PlusArray = new int[size];

            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    PlusArray[index] = array[i];
                    index++;
                }
            }

            return PlusArray;
        }
    }
}