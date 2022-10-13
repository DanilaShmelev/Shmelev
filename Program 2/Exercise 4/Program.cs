using Local_Class;

const int a = 3; 
const int b = 3; 
const int minValue = 0;
const int maxValue = 10;

int[,] array = LocalClass.GetDoubleRandomArray(minValue, maxValue, a, b);
Console.Write("Рандомный массив: ");
LocalClass.OutputArray(array, a, b);

int result = LocalClass.GetResultMultiplesPosition(array, a, b);
Console.Write($"\nСумма элементов четных позиций: {result}" );

Console.ReadKey();