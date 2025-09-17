using System.Reflection.Metadata;

namespace Laboratorio31
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CalculosMatematicos calc= new CalculosMatematicos();
            Console.WriteLine("Ingrese el valor1: ");
            calc.a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor2: ");
            calc.b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La suma de {0} y {1} es {2}", calc.a, calc.b, calc.Calcular);

        }
    }

    public class CalculosMatematicos()
    {
        const double PI = 3.14159;
        public int a { get; set; }
        public int b { get; set; }

        public int Calcular()
        {
            int sum = (a + b)*(a-b); 
            return sum;
        }

        public double calculoAreaCirculo(double radio)
        {
            double area = PI * (radio*radio);
            return area;
        }
    }
}