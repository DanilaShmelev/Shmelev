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

        public static int[] GetIndexesOf(int findNum, int[] array)
        {
            int size = (Array.FindAll(array, unknowVar => unknowVar == findNum)).Length;

            int[] indexes = new int[size];
            int ind = -1;
            int pos = 0;
            do
            {
                ind = Array.IndexOf(array, findNum, ind + 1);
                if (ind != -1)
                {
                    indexes[pos] = ind;
                    pos++;
                }
            }
            while (ind != -1);

            return indexes;
        }
    }
}