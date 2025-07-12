namespace UsingStatement;

public class Program
{
    public static void Main(string[] args)
    {
        #region "using" statement benefits

        using (var stream = new FileStream("emampleData.txt", FileMode.Open))
        {
            // Read from the stream
        }
        // stream.Dispose() here will be automatically called, even there is an exception occur.
        #endregion
    }
}