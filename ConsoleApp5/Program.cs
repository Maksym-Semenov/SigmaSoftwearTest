public class Program
{
    class SampleClass
    {
        public int Value { get; set; }
    }

    struct SampleStruct
    {
        public int Value { get; set; }
    }

    static void IncrementValue(SampleClass sample)
    {
        sample.Value++;
    }

    static void IncrementValue(SampleStruct sample)
    {
        sample.Value++;
    }

    static void IncrementValue(ref SampleStruct sample)
    {
        sample.Value++;
    }

    public static void Main()
    {
        SampleClass sampleClass = new SampleClass();
        IncrementValue(sampleClass);
        Console.Write(sampleClass.Value);

        SampleStruct sampleStruct = new SampleStruct();
        IncrementValue( sampleStruct);
        IncrementValue(ref  sampleStruct);
        Console.Write(sampleStruct.Value);
        Console.ReadLine();
    }
}