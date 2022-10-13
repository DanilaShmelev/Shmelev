using General;
using Local_Class;

const int n = 10; 
const int minValue = -1000;
const int maxValue = 1000;

int[] array;
array = GlobalClass.GetRandomArray(minValue, maxValue, n);
Console.Write("Рандомный массив: ");
GlobalClass.OutPutArray(array);

int max = LocalClass.GetMaxValue(array);
int min = LocalClass.GetMinValue(array);

Console.Write("\nСортированный массив: ");
LocalClass.SortArray(array);
GlobalClass.OutPutArray(array);

Console.Write($"\nМаксимальное значение: {max}, минимальное значение: {min}");
Console.ReadKey();