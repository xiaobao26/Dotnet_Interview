namespace MethodExtension.Utilities;

public static class StringExtension
{
    public static int WordCount(this string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }

        var ans = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return ans.Length;
    }
}