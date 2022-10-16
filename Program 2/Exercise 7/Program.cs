using General;
using Local_Class;

int n = 0;

Console.Write("Введите кол-во элементов в массиве: ");
n = GlobalClass.SetArraySize();

int[] array = new int[n];
array = GlobalClass.SetArray(array);

Console.Write("Отсортированный массив: ");
LocalClass.ReverseSortArray(array);
GlobalClass.OutPutArray(array);

Console.ReadKey();