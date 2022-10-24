using Local_Class;
using Global_Class;

Console.Write("Введите строку: ");
string str = GlobalClass.EnterString();

str = LocalClass.GetNormalString(str);

if (LocalClass.CheckPalindrome(str))
{
    Console.WriteLine("Строка является палиндромом");
}
else
{
    Console.WriteLine("Строка не является палиндромом");
}

Console.ReadKey();