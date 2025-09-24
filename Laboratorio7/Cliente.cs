using System;

public class Cliente
{
    private string nombre;
    private int monto;

    public Cliente(string name)
	{
		nombre = name;
		monto = 0;
	}

	public void Depositar(int m)
	{
		monto = monto + m;
	}

	public void Extraer(int m)
	{
		monto = monto - m
	}

	public int getMonto()
	{
		return monto;
	}

	public void Imprimir()
	{
		Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
	}
}
