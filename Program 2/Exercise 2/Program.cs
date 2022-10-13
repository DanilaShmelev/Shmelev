using Local_Class;

const int a = 3; 
const int b = 3; 
const int c = 3; 
const int minValue = 0;
const int maxValue = 10;

int[,,] array = LocalClass.GetRandomThreeArray(minValue, maxValue, a, b, c);
Console.Write("Рандомный массив: ");
LocalClass.OutputArray(array, a, b, c);

Console.Write("\n\nИзмененный массив: ");
LocalClass.ZeroArray(array, a, b, c);
LocalClass.OutputArray(array, a, b, c);

Console.ReadKey();