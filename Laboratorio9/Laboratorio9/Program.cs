internal class Program
{
    private static float precio, pago, cambio;
    private static byte metodo;

    private static void Main(string[] args)
    {
        Console.WriteLine("Simular Compra");
        Console.WriteLine("Ingrese el precio del producto (0.00$)");
        precio = float.Parse(Console.ReadLine());
        if (precio < 0)
        {
            do
            {
                Console.WriteLine("Ingrese un precio valido positivo");
                precio = float.Parse(Console.ReadLine());
            } while (precio < 0);
        }

        Console.WriteLine("\nIngrese su metodo de pago: \n1.Efectivo \n2.Tarjeta \n3.Cancelar");
        metodo = byte.Parse(Console.ReadLine());
        if (metodo < 1 || metodo > 3)
        {
            do
            {
                Console.WriteLine("Ingrese un opcion valida");
                metodo = byte.Parse(Console.ReadLine());
            } while (metodo < 1 || metodo > 3);
        }

        if (metodo == 1)
        {
            Console.WriteLine("Ingrese su pago (0.00$)");
            pago = float.Parse(Console.ReadLine());
            cambio = pago - precio;
            Console.WriteLine("Su cambio es de " + cambio);
        }
        else if (metodo == 2)
        {
            Console.WriteLine("Ingrese el numero de cuenta (0000-0000-0000-0000)");
            Console.ReadLine();
            Console.WriteLine("Pago procesado");
        }else
        {
            Console.WriteLine("Compra cancelada");
        }
        
    }
}