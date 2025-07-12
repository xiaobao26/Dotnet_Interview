using MethodExtension.Utilities;

namespace MethodExtension;

public class Program
{
    public static void Main(string[] args)
    {
        #region Method Extension

        string s1 = "Hello world";
        Console.WriteLine(s1.WordCount());
        #endregion
    }
}