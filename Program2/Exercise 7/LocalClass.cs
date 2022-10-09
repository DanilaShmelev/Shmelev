using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static int[] ReverseSortArray(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);

            return array;
        }
    }
}