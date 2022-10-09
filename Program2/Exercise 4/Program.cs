using Local_Class;

const int a = 3; 
const int b = 3; 
const int minValue = -1000;
const int maxValue = 1000;

int[,] array = LocalClass.GetTwoArray(minValue, maxValue, a, b);
Console.Write("Рандомный массив: ");
LocalClass.OutPutArray(array, a, b);

int sum = LocalClass.GetSumEvenPosition(array, a, b);
Console.Write($"\nСумма элементов четных позиций: {sum}");

Console.ReadKey();