using General;
using Local_Class;

int n = 0;

Console.Write("Введите кол-во элементов в массивах: ");
n = GlobalClass.GetArraySize();

int[] first_array = new int[n];
int[] second_array = new int[n];

Console.Write("Заполнение первого массива\n");
first_array = LocalClass.SetArray(first_array);

Console.Write("Заполнение второго массива\n");
second_array = LocalClass.SetArray(second_array);

if (LocalClass.IsSameArrays(first_array, second_array))
{
    Console.WriteLine("Массивы одинаковые");
}
else
{
    Console.WriteLine("Массивы разные");
}

GlobalClass.OutputArray(second_array);
Console.Write("\n");
GlobalClass.OutputArray(first_array);

Console.ReadKey();