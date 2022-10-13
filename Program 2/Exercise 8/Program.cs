using General;
using Local_Class;

const int minValue = -10;
const int maxValue = 10;
int n = 0;

Console.Write("Введите кол-во элементов в массиве: ");
n = GlobalClass.GetArraySize();

Console.Write("Рандомный массив: ");
int[] array = GlobalClass.GetRandomArray(minValue, maxValue, n);
GlobalClass.OutPutArray(array);

Console.Write("\nВведите искомое число: ");
int findNum = LocalClass.SetSearchNumber();

int[] indexes = LocalClass.GetIndexeOfNumbers(findNum, array);

if (indexes.Length == 0)
{
    Console.Write($"Нет вхождений числа {findNum}");
}
else
{
    LocalClass.GetSearchNumbers(indexes);
}

Console.ReadKey();