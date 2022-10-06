using Global_Class;
using Local_Class;

const int n = 10;
const int maxValue = 1000;
const int minValue = 0;

int[] array =GlobalClass.GetRandomArray(minValue, maxValue, n);
Console.WriteLine("Рандомный массив:");
GlobalClass.OutputArray(array);

Console.WriteLine("\nОтсортированный массив:");
LocalClass.SortArray(array);
GlobalClass.OutputArray(array);

int max = LocalClass.getMaxValue(array);
int min = LocalClass.getMinValue(array);
Console.Write($"\nМаксимальное значение = {max}, минимальное значение ={min}") ;

Console.ReadKey();