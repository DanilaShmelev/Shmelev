const int n = 10;
const int min = -1000;
const int max = 1000;

int[] array = new int[n];

Random rnd = new Random();

Console.Write("Рандомный массив: ");

int size = 0;

for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(min, max);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < n; i++)
{
    if (array[i] < 0)
    {
        size += 1;
    }
}

Console.Write("\nОтсортированный массив:");

int temp;

for (int i = 0; i < n - 1; i++)
{
    for (int j = i + 1; j < n; j++)
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

Console.Write("\nМассив с удвоенными отрицательными элементами: ");

int[] NewArray = new int[n+ size];
int index = 0;

for (int i = 0; i < n; i++)
{
    if (array[i] < 0)
    {
        NewArray[index] = array[i];
        NewArray[index + 1] = array[i];
        Console.Write(NewArray[index] + " " + NewArray[index+1]+ " ");
        index++;
    }
    else
    {
        NewArray[index] = array[i];
        Console.Write(NewArray[index] + " ");
    }
    index++;
}

Console.ReadKey();