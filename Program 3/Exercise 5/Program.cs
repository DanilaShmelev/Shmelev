using Global_Class;
using Local_Class;

Console.Write("Введите строку: ");
string str = GlobalClass.EnterString();

LocalClass.PrintDates(str);
Console.ReadKey();