const int max = 1000;
const int min = -1000;

int[,,] array;
array = new int[3, 3, 3];

Random random = new Random();

Console.Write("Рандомный массив: ");

for (int i = 0; i < 3; i++)
{
    Console.Write("\n");
    for (int j = 0; j < 3; j++)
    {
        Console.Write("\n");
        for (int k = 0; k < 3; k++)
        {
            array[i, j, k] = random.Next(min, max);
            Console.Write(array[i, j, k] + " ");
        }
    }
}

Console.Write("\nПреобразованный массив:");

for (int i = 0; i < 3; i++)
{
    Console.Write("\n");
    for (int j = 0; j < 3; j++)
    {
        Console.Write("\n");
        for (int k = 0; k < 3; k++)
        {
            if (array[i, j, k] > 0)
            {
                array[i, j, k] = 0;
            }
            Console.Write(array[i, j, k] + " ");
        }
    }
}
Console.ReadKey();