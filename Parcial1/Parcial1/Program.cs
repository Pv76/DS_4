internal class Program
{
    private static int tamano;
    private static int[,] arr;
    private static long valFinal = 1;

    private static void Main(string[] args)
    {
        Random rnd = new Random();

        Console.WriteLine("Parcial #1 - DS#4 - Enrique Cen");
        Console.WriteLine("Ingrese el tamano del Arreglo (N debe ser par): ");
        tamano = Int32.Parse(Console.ReadLine());

        if (tamano % 2 != 0)
        {
            do
            {
                Console.WriteLine("El valor ingresado no es valido!!!");
                Console.ReadKey();
                Console.WriteLine("Ingrese nuevamente: ");
                tamano = Int32.Parse(Console.ReadLine());
            } while (tamano % 2 != 0);
        }

        int[,] arr = new int[tamano , tamano];
        Console.Write("\n\n");

        for (int y = 0; y < tamano; y++)
        {
            for (int x = 0; x < tamano; x++)
            {
                if((y + 1) % 2 == 0)
                {
                    arr[x, y] = rnd.Next(101,200);
                    valFinal = valFinal * arr[x, y];
                }
                else if(y % 2 != 0)
                {
                    arr[x, y] = 0;
                }
                Console.Write(arr[x, y] + " | ");
            }
            Console.Write("\n");
        }

        Console.WriteLine("\n\nEl Factorial de todos los aleatorio es: " + valFinal);

    }
}