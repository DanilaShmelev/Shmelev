using System.Text;

namespace Local_Class
{
    internal static class LocalClass
    {
        internal static string GetNormalString(string str)
        { 
            StringBuilder temp = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i])) //не буква ли?
                {
                    temp.Append(char.ToLower(str[i]));
                }
            }

            return temp.ToString();
        }

        internal static bool CheckPalindrome(string str)
        {
            StringBuilder temp = new StringBuilder();

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            for (int i = 0; i < str.Length; i++)
            {
                temp.Append(charArray[i]);
            }

            return str.Equals(temp.ToString()); //сравнение двух строк
        }
    }
}
