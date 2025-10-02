internal class Program
{
    private static float lado1, lado2, lado3;

    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor de su lado 1");
        lado1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de su lado 2");
        lado2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de su lado 3");
        lado3 = float.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("Su triangulo es Equilatero");
        }
        else if (lado1 != lado2 && lado2 != lado3)
        {
            Console.WriteLine("Su triangulo es Escaleno");
        }
        else
        {
            Console.WriteLine("Su triangulo es Isosceles");
        }
    }
}