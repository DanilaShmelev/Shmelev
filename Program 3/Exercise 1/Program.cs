using Global_Class;
using Local_Class;

Console.Write("Введите строку: ");
string str = GlobalClass.EnterString();

string[] arrayString = LocalClass.GetStringWithoutSymbols(str);
double averageLength = LocalClass.GetAverageLength(arrayString);

Console.WriteLine($"Средняя длина слова = {averageLength}");
Console.ReadKey();