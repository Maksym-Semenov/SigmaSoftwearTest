IMyInter qwe1 = new MyInter1();
IMyInter qwe2 = new MyInter2();

Console.WriteLine(qwe1.GetType());
Console.WriteLine(qwe2.GetType());

Console.ReadLine();

public interface IMyInter
{
    
}

public class MyInter1 : IMyInter
{
    
}

public class MyInter2 : IMyInter
{

}