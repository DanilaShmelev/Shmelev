using Local_Class;

const int a = 3; 
const int b = 3; 
const int minValue = 0;
const int maxValue = 10;

int[,] array = LocalClass.GetDoubleRandomArray(minValue, maxValue, a, b);
Console.Write("Рандомный массив: ");
LocalClass.OutputArray(array);

int result = LocalClass.GetResultMultiplesPosition(array);
Console.Write($"\nСумма элементов четных позиций: {result}" );

Console.ReadKey();