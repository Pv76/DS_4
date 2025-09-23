namespace Laboratorio51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Cargar();
            pv.Imprimir();
        }

        private int[] sueldos;

        public void Cargar()
        {
            sueldos = new int[6];
            for (int f = 1; f <= 5; f++)
            {
                Console.Write("Ingrese sueldo del operario " + f + ": ");
                String linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            Console.Write("Los 5 sueldos de los operarios \n");
            for (int f = 1; f <= 5; f++)
            {
                Console.Write("[" + sueldos[f] + "] ");
            }
            Console.ReadKey();
        }
    }
}