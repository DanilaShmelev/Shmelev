const int max = 10;
const int min = 0;

int[,] array;
array = new int[3, 3];

Random rnd = new Random();   

int sum = 0;

Console.WriteLine("Двумерный массив:");

for (int i = 0; i < 3; i++)
{
    Console.Write("\n");
    for (int j = 0; j < 3; j++)
    {
        array[i, j] = rnd.Next(min, max);
        Console.Write(array[i,j] + " ");
    }
}

for (int i = 0; i<3;i++)
{
    Console.Write("\n");
    for (int j=0; j<3; j++)
    {
        if ((i + j) % 2 == 0)
        {
            sum +=array[i, j];
        }
    }
}

Console.WriteLine($"Сумма элементов, находящихся на четной позиции = {sum}");