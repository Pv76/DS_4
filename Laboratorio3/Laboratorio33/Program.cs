using System;

namespace Laboratorio33
{
    public class Program
    {

        private static void Main(string[] args)
        {
            int perimetro,alto,ancho;
            Console.WriteLine("Calculo de Perimetro de Rectangulo");
            Console.WriteLine("Ingrese la base: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la altura: ");
            alto = Convert.ToInt32(Console.ReadLine());

            perimetro = calculoPerimetro(alto,ancho);

            Console.WriteLine("El perimetro del triangulo b = {0} y h = {1} es de {2}", ancho, alto, perimetro);
        }
        public static int calculoPerimetro(int alto, int ancho)
        {
            return 2*(alto+ancho);
        }
    }
}