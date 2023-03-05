static void Main()
{
    int number = 42;
    Action printNumber = () => Console.WriteLine(--number);
    number++;
    printNumber();
}