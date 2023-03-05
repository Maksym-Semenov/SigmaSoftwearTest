public class A
{
    private static int _count = 0;

    public A()
    {
        _count++;
    }

    public string Title { get; set; }

    public int GetCounterVal()
    {
        return _count;
    }
}

public class B : A
{
}

public class Program
{
    static void Main(string[] args)
    {
        var objA1 = new A();
        objA1.Title = "objA1";
        var objB1 = new B();
        objB1.Title = "objB1";
        var objB2 = new B();
        objB2.Title = "objB2";

        Console.WriteLine(objA1.GetCounterVal());
        Console.ReadLine();
    }
}