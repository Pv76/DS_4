using Laboratorio94;
internal class Program
{
  
    private static int cant, num1 ,num2;
    private static void Main(string[] args)
    {
        Aleatorio aleatorio = new Aleatorio();

        Console.WriteLine("Ingrese la cantidad de numeros:");
        cant = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el rango inferior: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el rango superior: ");
        num2 = int.Parse(Console.ReadLine());

        aleatorio.generarArr(cant, num1, num2);
    }
}
