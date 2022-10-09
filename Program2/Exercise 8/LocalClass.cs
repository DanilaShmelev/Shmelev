using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static void GetNumberPosition(int[] array)
        {
            Console.Write("Позиция искомого числа: ");
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
                    Console.WriteLine("На вход принимаются только int значениия");
                }
                break;
            }

            return findNum;
        }

        public static int[] GetIndexesOf(int findNum, int[] array)
        {
            int size = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == findNum)
                {
                    size++;
                }
            }

            int[] indArray = new int[size];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == findNum)
                {
                    indArray[index] = i;
                    index++;
                }
            }

            return indArray;
        }
    }
}