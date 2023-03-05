static void Main()
{
    var counter = 0;
    for (var i = 0; i < 3; i++)
    {
        counter++;
        for (var j = 1; j < 3; j++)
            counter++;
    }
    Console.WriteLine(counter);
}