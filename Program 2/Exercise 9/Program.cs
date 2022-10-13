using General;
using Local_Class;

int n = 0;

Console.Write("Введите кол-во элементов в массивах: ");
n = GlobalClass.GetArraySize();

int[] first_numbers = new int[n];
int[] second_numbers = new int[n];

Console.Write("Заполнение первого массива\n");
first_numbers = LocalClass.SetArrayElement(first_numbers);

Console.Write("Заполнение второго массива\n");
second_numbers = LocalClass.SetArrayElement(second_numbers);

if (LocalClass.ComparisonArrays(first_numbers, second_numbers))
{
    Console.Write("Массивы одинаковые");
}
else
{
    Console.Write("Массивы разные");
}

Console.Write("\n");
GlobalClass.OutPutArray(second_numbers);
Console.Write("\n");
GlobalClass.OutPutArray(first_numbers);

Console.ReadKey();