public static class StringUtils
{
    public static bool Comparar(string s1, string s2)
    {
        int length = s1.Length > s2.Length ? s2.Length : s1.Length;

        for(int i = 0; i < length; i++)
        {
            if(s1.ToCharArray()[i] < s2.ToCharArray()[i])
            {
                return true;
            }
            else if(s1.ToCharArray()[i] > s2.ToCharArray()[i])
            {
                return false;
            }
        }

        return s1.Length <= s2.Length;
    }
}