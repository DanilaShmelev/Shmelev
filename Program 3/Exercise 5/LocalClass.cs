using System.Text;
using System.Text.RegularExpressions;

namespace Local_Class
{
    internal static class LocalClass
    {
        internal static void PrintDates(string str)
        {
            string pattern = @"(?<day>0[1-9]|[1-2][0-9]|3[0-1])-(?<month>0[1-9]|1[0-2])-(?<year>[0-9]{4})";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(str);

            if (matches.Count > 0)
            {
                StringBuilder message = new StringBuilder();

                for (int i = 0; i < matches.Count; i++)
                {
                    message.Append($"{matches[i].Value}, где день = {matches[i].Groups["day"]}");
                    message.Append($", месяц = {matches[i].Groups["month"]}, год = {matches[i].Groups["year"]}\n");
                }

                Console.WriteLine(message.ToString());
            }
            else
            {
                Console.WriteLine("Дата не верной формы записи!!!");
            }
        }
    }
}
