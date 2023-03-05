
void Test1()
{
    var test = 1;
    test = "string";
}

void Test2()
{
    object test = 1;
    test = "string";
}

void Test3()
{
    var test = new object();
    test.Property = 1;
}

void Test4()
{
    dynamic test = "some string";
    test = 1;
}

void Test5()
{
    object test = new object();
    test = 1;
}