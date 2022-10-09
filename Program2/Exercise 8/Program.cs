using General;
using Local_Class;

const int minValue = 0;
const int maxValue = 10;
int n = 0;

Console.Write("Введите кол-во элементов в массиве: ");
n = GlobalClass.GetArraySize();

Console.Write("Рандомный массив: ");
int[] array = GlobalClass.GetRandomArray(minValue, maxValue, n);
GlobalClass.OutputArray(array);

Console.Write("\nВведите искомое число: ");
int findNum = LocalClass.SetSearchNumber();

int[] indArray = LocalClass.GetIndexesOf(findNum, array);

if (indArray.Length == 0)
{
    Console.Write($"Нет вхождений числа {findNum}");
}
else
{
    LocalClass.GetNumberPosition(indArray);
}

Console.ReadKey();