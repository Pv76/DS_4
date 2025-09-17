using System;
namespace Laboratorio2_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);
        }

        public class MyClass()
        {
            public static int Valor;
        }
    }
}