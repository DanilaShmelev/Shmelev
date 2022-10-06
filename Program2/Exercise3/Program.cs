const int n = 10;
const int max = 10000;
const int min = -10000;

int[] array;
array = new int[n];

int sum = 0;
Random rnd = new Random();

Console.WriteLine("Рандомный одномерный массив:");

for (int i = 0;i<n;i++)
{
    array[i] = rnd.Next(min, max);
    Console.Write(array[i]+ " ");
}

for (int i = 0; i<n;i++)
{
    if (array[i] > 0)
    {
        sum += array[i];
    }
}

Console.WriteLine("\nСумма положительных элементов = " + sum);
Console.ReadKey();