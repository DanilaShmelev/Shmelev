using General;
using Local_Class;

int n = 0;

Console.Write("Введите кол-во элементов в массиве: ");
n = GlobalClass.GetArraySize();

int[] array = new int[n];
array = GlobalClass.SetArray(array);

Console.Write("Отсортированный массив: ");
LocalClass.ReverseSortArray(array);
GlobalClass.OutputArray(array);

Console.ReadKey();