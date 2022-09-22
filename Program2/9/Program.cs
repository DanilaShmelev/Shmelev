int elementCount = 0;
bool check = true;

bool repeat(int i, int element, int[] array)
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

void array1(int[] array)
{
    for (int i = 0; i < elementCount; i++)
    {
        int elementArray = 0;
        while (true)
        {
            Console.Write($"Введите элемент [{i}]: ");
            if (!int.TryParse(Console.ReadLine(), out elementArray))
            {
                Console.WriteLine("На вход принимаются только int значения" );
                continue;
            }
            else if (repeat(i, elementArray, array))
            {
                Console.Write("Замечено повторение\n");
                continue;
            }
            array[i] = elementArray;
            break;
        }
    }
}


while (check)
{
    Console.Write("Введите сколько будет элементов в массиве:\t");
    if (!int.TryParse(Console.ReadLine(), out elementCount))
    {
        Console.WriteLine("Вы ввели число не верного типа данных!!!");
    }
    else if (elementCount < 1)
    {
        Console.WriteLine("Массив не может быть меньше идиницы!");
    }
    else
    {
        check = false;
    }
}

int[] first_array = new int[elementCount];
int[] second_array = new int[elementCount];

Console.Write("Заполнение первого массива\n");
array1(first_array);

Console.Write("Заполнение второго массива\n");
array1(second_array);

Array.Sort(first_array);
Array.Sort(second_array);

bool flag = true;
for (int i = 0; i < elementCount; i++)
{
    if (first_array[i] != second_array[i])
    {
        Console.Write("Массивы не равны!");
        flag = false;
        break;
    }
}
   if (flag)
   {
        Console.Write("Массивы равны!!!");
   }

Console.ReadKey();