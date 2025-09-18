namespace Laboratorio44
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota del estudiante:");
            float score = float.Parse(Console.ReadLine());

            if(score >= 70)
            {
                Console.WriteLine();
                Console.WriteLine($"SU nota es {score} ha aprobado");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Su note es {score} ha reprobado, debe repetir");
            }    
        }
    }
}