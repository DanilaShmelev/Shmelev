using EnglishText;

string text = "In this teXt this Text is written and this tExt is read. English text text. This sports text";
Dictionary<string, int>? dict = FoundWords.GetDictionary(text);
if (dict is null)
{
    Console.WriteLine("Эта строка пустая или null!");
    return;
}

foreach (var item in dict)
{
    Console.WriteLine($"Слово {item.Key} встречается {item.Value} раз");
}