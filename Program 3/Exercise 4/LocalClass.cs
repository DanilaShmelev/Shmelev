using System.Text;
using System.Text.RegularExpressions;

namespace Local_Class
{
    internal static class LocalClass
    {
        internal static string ReplaceTags(string str)
        {
            string pattern = @"(\<*\>)";
            string sign = "_";

            Regex regex = new Regex(pattern);

            return regex.Replace(str, sign);
        }

        internal static string SecondOpinionReplaceTags(string str)
        {
            StringBuilder strBuilder = new StringBuilder();
            int index = 0;

            while (true)
            {
                int indexFirst = str.IndexOf("<", index);
                int indexSecond = str.IndexOf(">", index);
                if (indexFirst == -1 || indexSecond == -1)
                {
                    strBuilder.Append(str.Substring(index, str.Length - index));
                    break;
                }

                strBuilder.Append(str.Substring(index, indexFirst - index) + "_");
                index = indexSecond + 1;
            }

            return strBuilder.ToString();
        }
        
    }
}
