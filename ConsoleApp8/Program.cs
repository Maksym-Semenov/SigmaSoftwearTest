public class Program
{
    public static void Main()
    {
        try
        {
            var res = 1 / GetDivider();
            Console.WriteLine("try");
        }
        catch
        {
            Console.WriteLine("catch");
        }
        finally
        {
            Console.WriteLine("finally");
        }
    }

    private static int GetDivider()
    {
        return 0;
    }
}