using System.Text.RegularExpressions;

namespace Local_Class
{
    internal static class LocalClass
    {
        internal static bool CheckMail(string str)
        {
            string pattern = @"(?:^[a-zA-Z0-9](?:[a-zA-Z0-9\-_]*[a-zA-Z0-9])?)@" +
                            @"(?:[a-zA-Z0-9](?:[a-zA-Z0-9\-_]*[a-zA-Z0-9])?\.)+(?:[a-zA-Z]{2,6})$";

            if (Regex.IsMatch(str, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
