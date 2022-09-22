const int n = 10;
const int max = 1000;
const int min = -1000;

int[] array;
array = new int[n]; 

Random rnd = new Random();

Console.WriteLine("Рандомный массив:");
int max_value = max;
int min_value = min;


for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(min, max);
    Console.Write(array[i] + " ");
}

Console.WriteLine("\nОтсортированный массив:");

int temp;

for (int i = 0;i<n-1;i++)
{
    for (int j = i+1;j < n;j++)
    {
        if (array[i] > array[j])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    Console.Write(array[i] + " ");
   
}
max_value = array[9];
min_value = array[0];

Console.Write(array[n - 1]);
Console.Write("\nМаксимальное значение = " + max_value + ", минимальное значение = " + min_value);
Console.ReadKey();