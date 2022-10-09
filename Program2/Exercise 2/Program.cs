using Local_Class;

const int a = 3; 
const int b = 3; 
const int c = 3; 
const int minValue = -1000;
const int maxValue = 1000;

int[,,] array = LocalClass.GetThreeArray(minValue, maxValue, a, b, c);
Console.Write("Рандомный массив: ");
LocalClass.OutPutArray(array, a, b, c);

Console.Write("\n\nИзмененный массив: ");
LocalClass.ChangeArray(array, a, b, c);
LocalClass.OutPutArray(array, a, b, c);

Console.ReadKey();