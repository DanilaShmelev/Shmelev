using General;
using Local_Class
;

const int n = 10; 
const int minValue = -100;
const int maxValue = 100;

int[] array = GlobalClass.GetRandomArray(minValue, maxValue, n);
Console.Write("Рандомный массив: ");
GlobalClass.OutPutArray(array);

Console.Write("\nНовый массив: ");
array = LocalClass.DoubleMinusElements(array);
GlobalClass.OutPutArray(array);

Console.ReadKey();