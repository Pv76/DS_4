using System;

namespace Laboratorio2
{
     public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client();
            client.FirstName = "Pepe";
            client.LastName = "Aya";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.getFullName());
            Console.WriteLine("HI");
            Sumar(1, 2);
        }

        public static void Sumar(int val1, int val2)
        {
            int variableLocal = val1 + val2;
            Console.WriteLine(variableLocal);
        }
    }

    public class Client()
    {
        public int Id {  get; set; }
        public String FirstName {  get; set; }
        public String LastName { get; set; }
        public ushort Age { get; set; }
        public string getFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
