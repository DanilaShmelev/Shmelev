using Local_Class;

const int a = 3; 
const int b = 3; 
const int c = 3; 
const int minValue = -10;
const int maxValue = 10;

int[,,] array = LocalClass.GetRandomThreeArray(minValue, maxValue, a, b, c);
Console.Write("Рандомный массив: ");
LocalClass.OutputArray(array);

Console.Write("\n\nИзмененный массив: ");
LocalClass.ReplacePlusElements(array);
LocalClass.OutputArray(array);

Console.ReadKey();