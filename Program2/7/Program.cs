
bool check = true;
int elementCount = 0;
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

check = true;
int[] array =new int [elementCount];

for (int i = 0; i < elementCount; i++)
{
    int elementArray = 0;
    while (check)
    {
        Console.Write($"Введите элемент [{i}]: ");
        if (!int.TryParse(Console.ReadLine(), out elementArray))
        {
            Console.WriteLine("На вход принимаются только int значения");
            continue;
        }
        array[i] = elementArray;
        break;
    }
}

Console.Write("\n");
Console.Write("Отсортированный массив:");
Array.Sort(array);
Array.Reverse(array);

for (int i = 0; i < elementCount; i++)
{
    Console.Write(array[i] + " ");
}
 
Console.ReadKey();