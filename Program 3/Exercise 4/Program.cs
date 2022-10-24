using Global_Class;
using Local_Class;

Console.Write("Введите строку: ");
string str = GlobalClass.EnterString();

string str2 = LocalClass.ReplaceTags(str);
Console.WriteLine($"Строка с регулярным выражением: {str2}");

str = LocalClass.SecondOpinionReplaceTags(str);
Console.WriteLine($"Строка без регулярного выражения: {str}");

Console.ReadKey();