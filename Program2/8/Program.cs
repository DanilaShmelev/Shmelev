const int max = 10;
const int min = 0;

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

Random rnd = new Random();

Console.Write("Массив с рандомными числами:\t");

int[] array =new int[elementCount];

for (int i = 0; i < elementCount; i++)
{
    array[i] = rnd.Next(min, max);
    Console.Write(array[i] + " ");
}

Console.Write("\nВведите искомое число: ");

int find_number = 0;
check = true;

while (check)
{
    if (!int.TryParse(Console.ReadLine(), out find_number))
    {
        Console.WriteLine("На вход принимаются только int значения");
    }
    else
    {
        check = false;
    }
    break;
}

Console.Write($"Вхождения числа {find_number}:");
check = false;
for (int i = 0;i< elementCount;i++)
{
    if (array[i] == find_number)
    {
        Console.Write(" " + i);
        check = true;
    }
}
if (!check)
{
    Console.Write("Число не найдено!!!");
}

Console.ReadKey();
