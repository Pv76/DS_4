internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { Nombre = "Juan", Edad = 10 },
            new Estudiante { Nombre = "Sofía", Edad = 11 },
            new Estudiante { Nombre = "Ana", Edad = 12 },
        };


        foreach (Estudiante estudiante in estudiantes)
        {
            Console.WriteLine("Nombre: " + estudiante.Nombre + ", Edad: " + estudiante.Edad);
        }
    }

}
class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

