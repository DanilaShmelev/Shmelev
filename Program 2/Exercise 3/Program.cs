using General;
using Local_Class;

const int n = 10; 
const int minValue = -10;
const int maxValue = 10;

int[] array = GlobalClass.GetRandomArray(minValue, maxValue, n);
Console.Write("Рандомный массив: ");
GlobalClass.OutPutArray(array);

Console.Write($"\nПоложительные элементы:");
LocalClass.PrintPlusElements(array);

int sum = LocalClass.GetSumPlusElements(array);
Console.Write($"\nСумма положительных элементов: {sum}");

Console.ReadKey();