public class Program
{
    private static int _number = 0;

    static void Main(string[] args)
    {
        var number = GetUpdatedNumber(_number);
        _number += number;
        number = GetUpdatedNumber(_number);
        _number += number;
        number = GetUpdatedNumber(_number);
    }

    private static int GetUpdatedNumber(int number)
    {
        ++number;
        Console.Write(_number);
        return number;
    }
}