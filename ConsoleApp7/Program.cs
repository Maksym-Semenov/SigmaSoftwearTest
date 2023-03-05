public class Program
{
    public static void GenerateValues(out int testInt, out string testString, out bool testBool)
    {
        object valuesObj = 1;
        testInt = testInt + (int)valuesObj;

        valuesObj = "str";
        testString = testString + (string)valuesObj;

        valuesObj = false;
        testBool = testBool || (bool)valuesObj;
    }

    public static void Main()
    {
        var testInt = 2;
        var testStr = "test";
        var testBool = true;
        GenerateValues(out testInt, out testStr, out testBool);
        Console.WriteLine($"{testInt}|{testStr}|{testBool}");
    }
}