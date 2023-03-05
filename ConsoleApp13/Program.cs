public class Program
{
    public static void GenerateValues(ref int testInt, ref string testString, ref bool testBool)
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
        GenerateValues(ref testInt, ref testStr, ref testBool);
        Console.WriteLine($"{testInt}|{testStr}|{testBool}");
    }
}