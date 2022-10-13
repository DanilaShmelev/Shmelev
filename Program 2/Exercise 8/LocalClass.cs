using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static void GetSearchNumbers(int[] array)
        {
            Console.Write("Вхождения искомого числа: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public static int SetSearchNumber()
        {
            int findNum;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out findNum))
                {
                    Console.WriteLine("На вход принимаются только int значения");
                }
                break;
            }

            return findNum;
        }

        public static int[] GetIndexeOfNumbers(int findNum, int[] array)
        {
            int size = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == findNum)
                {
                    size++;
                }
            }

            int[] indexes = new int[size];
            int ind = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == findNum)
                {
                    indexes[ind] = i;
                    ind++;
                }
            }

            return indexes;
        }
    }
}