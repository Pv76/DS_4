internal class Program
{
    private static void Main(string[] args)
    {
        Banco banco = new Banco();
        banco.Operar();
        banco.DepositosTotales();
        Console.ReadKey();

    }
}