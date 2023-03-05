public class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        long b = 6;
        byte c = 7;
        bool test = false;

        var r1 = test || a > b && c > b || true;
        var r2 = (a != b && b > c) || test || (a < b && b > c);
        var r3 = (a < b || b > c) && (a < b || b > c);
        var r4 = (a < b || b > c) && (a < b || b > c) || !test;
        var r5 = !test || (a < b < c);

        Console.WriteLine($"{r1} | {r2} | {r3} | {r4} | {r5}");
    }
}