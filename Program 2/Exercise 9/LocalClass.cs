using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static bool IfRepeatElementsInArray(int i, int arrayElement, int[] array)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j] == arrayElement)
                {
                    return true;
                }
            }

            return false;
        }

        public static int[] SetArrayElement(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int element = 0;
                while (true)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    if (!int.TryParse(Console.ReadLine(), out element))
                    {
                        Console.WriteLine("На вход принимаются только int значения");
                        continue;
                    }
                    else if (IfRepeatElementsInArray(i, element, array))
                    {
                        Console.Write("Замечено повторение\n");
                        continue;
                    }
                    array[i] = element;
                    break;
                }
            }

            return array;
        }

        public static bool ComparisonArrays(int[] first_numbers, int[] second_numbers)
        {
            Array.Sort(first_numbers);
            Array.Sort(second_numbers);

            if (first_numbers.Length != second_numbers.Length)
            {
                return false;
            }
            for (int i = 0; i < first_numbers.Length; i++)
            {
               
                if (first_numbers[i] != second_numbers[i]) 
                {
                    return false;
                }
            }

            return true;
        }
    }
}