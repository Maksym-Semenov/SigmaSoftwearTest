public class Program
{
    static void IncrementNumber(ref int number)
    {
        number++;
        number = new Int32();
    }

    static void DecrementNumber(int number)
    {
        number--;
    }

    static void GetNumber(out int number)
    {
        number = 42;
    }

    public static void Main()
    {
        int someNumber;
        GetNumber(out someNumber);
        IncrementNumber(ref someNumber);
        DecrementNumber(someNumber);
        Console.WriteLine(someNumber);
        Console.ReadLine();
    }
}