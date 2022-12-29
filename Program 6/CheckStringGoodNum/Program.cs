using CheckStringGoodNum;

string str = "592";
bool isGood = str.IsGoodNum();

if (isGood)
{
    Console.WriteLine("Строка является положительным целым числом");
}
else
{ 
    Console.WriteLine("Строка является не положительным целым числом");
}