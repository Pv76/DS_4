namespace Laboratorio3
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int num1, num2, sum;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num1;
            Console.WriteLine("La suma de {0} y {1} es {2}", num1, num2, sum);
        }
    }
}