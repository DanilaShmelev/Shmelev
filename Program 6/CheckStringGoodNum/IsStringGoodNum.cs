namespace CheckStringGoodNum
{
    internal static class IsStringGoodNum
    {
        public static bool IsGoodNum(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i])) 
                {
                    return false;
                }
            }

            return true;
        }
    }
}
