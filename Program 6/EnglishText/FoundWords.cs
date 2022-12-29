namespace EnglishText
{
    internal static class FoundWords
    {
        public static Dictionary<string, int>? GetDictionary(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            string[] words = text.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                return null;
            }

            Dictionary<string, int> temp = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string item in words)
            {
                if (temp.ContainsKey(item))
                {
                    temp[item]++;
                }
                else
                {
                    temp.Add(item, 1);
                }
            }

            return temp;
        }
    }
}
