
namespace Laboratorio94;

public class Aleatorio
{
    Random rnd = new Random();

    public int generarNum(int num1, int num2)
    {
        return rnd.Next(num1, num2);
    }

    public void generarArr(int cant,int num1, int num2)
    {
        int[] arr = new int[cant];
        foreach (int i in arr)
        { 
            arr[i] = rnd.Next(num1,num2);
            Console.WriteLine(arr[i]);
        }

    }
}

