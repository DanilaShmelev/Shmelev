using General;
using Local_Class;

const int n = 10; //число элементов в массиве
const int minValue = -1000;
const int maxValue = 1000;

int[] array = GlobalClass.GetRandomArray(minValue, maxValue, n);
Console.Write("Рандомный массив: ");
GlobalClass.OutputArray(array);

Console.Write("\nСортированный массив: ");
LocalClass.SortArray(array);
GlobalClass.OutputArray(array);

int max = LocalClass.GetMaxValue(array);
int min = LocalClass.GetMinValue(array);

Console.Write($"\nМаксимальное значение: {max}, минимальное значение: {min}");
Console.ReadKey();