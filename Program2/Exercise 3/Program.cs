using General;
using Local_Class;

const int n = 10;
const int minValue = -1000;
const int maxValue = 1000;

int[] array = GlobalClass.GetRandomArray(minValue, maxValue, n);
Console.Write("Рандомный массив: ");
GlobalClass.OutputArray(array);

int sum = LocalClass.GetSumPlusElements(array);
Console.Write($"\nСумма положительных элементов: {sum}") ;

Console.ReadKey();