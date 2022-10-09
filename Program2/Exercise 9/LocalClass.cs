using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static bool RepeatElementInArray(int i, int element, int[] array)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j] == element)
                {
                    return true;
                }
            }

            return false;
        }

        public static int[] SetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int elementArray = 0;
                while (true)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    if (!int.TryParse(Console.ReadLine(), out elementArray))
                    {
                        Console.WriteLine("На вход принимаются только int значения");
                        continue;
                    }
                    else if (RepeatElementInArray(i, elementArray, array))
                    {
                        Console.Write("Замечено повторение\n");
                        continue;
                    }
                    array[i] = elementArray;
                    break;
                }
            }

            return array;
        }

        public static bool IsSameArrays(int[] first_array, int[] second_array)
        { 

            Array.Sort(first_array);
            Array.Sort(second_array);

            for (int i = 0; i < first_array.Length; i++)
            {
                if ((first_array[i] != second_array[i]) || (first_array.Length !=second_array.Length))
                {
                    return false;
                }
            }

            return true;
        }
    }
}