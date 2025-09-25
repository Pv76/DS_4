using System;

public class Banco
{
	private Cliente client1, client2, client3;

	public Banco()
	{
        client1 = new Cliente("Jonas");
        client2 = new Cliente("Ana");
        client3 = new Cliente("Pedro");
    }

    public void Operar()
    {
        client1.Depositar(100);
        client2.Depositar(150);
        client3.Depositar(200);
        client3.Extraer(150);
    }

    public void DepositosTotales()
    {
        int t = client1.getMonto() + client2.getMonto() + client3.getMonto();
        Console.WriteLine("El total de dinero en el banco es: " + t);

        client1.Imprimir();
        client2.Imprimir();
        client3.Imprimir();
    }
}
