using Local_Class;
using Global_Class;

Console.Write("Введите электронную почту: ");
string str = GlobalClass.EnterString();

if (LocalClass.CheckMail(str))
{
    Console.WriteLine($"Является электронной почтой {str} ");
}
else
{
    Console.WriteLine($"Не является электронной почтой {str} ");
}

Console.ReadKey();