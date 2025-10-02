internal class Program
{
    private static int i;
    private static void Main(string[] args)
    {
        Console.WriteLine("Numeros Pares:");
        for (i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ",");
            }
        }

        Console.WriteLine("\n\nNumeros divisible por 3:");
        for (i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.Write(i + ",");
            }

        }
    }
}