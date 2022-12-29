namespace SumArray
{
    internal static class IntArrayGetSum
    {
        public static int GetSum(this int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            
            return sum;
        }
    }
}
