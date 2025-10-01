
abstract class ClaseAbstracta
{
    abstract protected string tomarValor();
    abstract public string prefixValor(string prefix);

    public void printOut()
    {
        Console.WriteLine(tomarValor());
    }
}
class ClaseConcretal : ClaseAbstracta
{
    protected override string tomarValor()
    {
        return "ClaseConcretal";
    }
    public override string prefixValor(string prefix)
    {
        return $"{prefix}ClaseConcretal";
    }
}

class ClaseConcreta2 : ClaseAbstracta
{
    protected override string tomarValor()
    {
        return "ClaseConcreta2";
    }
    public override string prefixValor(string prefix)
    {
        return $"{prefix}ClaseConcreta2";
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        ClaseConcretal concretal = new ClaseConcretal(); 
        concretal.printOut();
        Console.WriteLine(concretal.prefixValor("ES_"));

        ClaseConcreta2 concreta2 = new ClaseConcreta2(); 
        concreta2.printOut();
        Console.WriteLine(concreta2.prefixValor("ES_"));
    }
}
