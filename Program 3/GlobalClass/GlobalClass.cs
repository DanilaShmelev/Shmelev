namespace Global_Class;

public static class GlobalClass
{
    public static string EnterString()
    {
        string? str = Console.ReadLine();
        if (string.IsNullOrEmpty(str))
        {
            Console.Write("Строка пустая!");
            Console.ReadKey();
            Environment.Exit(0);
        }

        return str;
    }
}