using System;


namespace Laboratorio32
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            Console.WriteLine("Calculo de Area de Circulo");
            Console.WriteLine("Ingrese el radio: ");
            Console.WriteLine("El area del circulo es: {0}", calculoAreaCirculo(Convert.ToDouble(Console.ReadLine())));
        }
        public static double calculoAreaCirculo(double radio)
        {
            const double PI = 3.14159;
            double area = PI * (radio * radio);
            return area;
        }
    }

}