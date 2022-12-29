using DynamicArray;

DynamicArray<int> array = new(1);
array.Notify += NotificationMessage;
//array.Dispose();
array.Add(2);
array.Add(3);
array.Add(5);
array.Add(3);
array.Insert(7, 1);
array.Add(3);
array.Add(5);
array.Add(1);
array.Add(2);

Console.WriteLine(array.Length);
Console.WriteLine(array.Capacity);

foreach (var item in array)
{
    Console.Write(item + " ");
}
Console.Write("\n");

array.Remove(3, EqualsFunc);

foreach (var item in array)
{
    Console.Write(item + " ");
}

Console.Write("\n");

Console.WriteLine(array.Length);
Console.WriteLine(array.Capacity);

array.Insert(7, 1);
Console.WriteLine(array.Length);

Console.WriteLine("====" + array[2]);

DynamicArray<int> obj1 = new(5);

int[] hello = { 1, 3, 5 };

array.AddRange(hello);

foreach (var item in array)
{
    Console.Write(item + " ");
}
Console.WriteLine(null == array);

foreach (var item in array)
{
    Console.Write(item + " ");
}

Console.ReadKey();

bool EqualsFunc(int first, int second)
{
    if (first == second) return true;
    return false;
}

void NotificationMessage(object sender, DynamicArrayEventArgs e)
{
    Console.WriteLine($"Старая емкость: {e.OldCapacity}, новая емкость: {e.NewCapacity}");
}