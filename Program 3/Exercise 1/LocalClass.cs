using System;

namespace Local_Class
{
    public static class LocalClass
    {
        public static string[] GetStringWithoutSymbols(string str)
        {
            return str.Split(new char[] { ' ', ',', ':', '.', '!', '?', '-', '(', ')', '"', ';', }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static double GetAverageLength(string[] arrayString)
        {
            double allWordLength = 0.0;

            for (int i = 0; i < arrayString.Length; i++)
            {
                allWordLength += arrayString[i].Length;
            }

            if (arrayString.Length > 0)
            {
                return allWordLength / arrayString.Length;
            }
            else
            {
                return 0;
            }
        }
    }
}
