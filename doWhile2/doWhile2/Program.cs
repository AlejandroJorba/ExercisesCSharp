using System;

namespace doWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCuenta;
            float saldo;
            float suma = 0;
            string datos;
            do
            {
                
                Console.Write("Ingrese el número de cuenta: ");
                datos = Console.ReadLine();
                numCuenta = int.Parse(datos);
                if (numCuenta > 0) { 
                         Console.Write("Ingrese el saldo de la cuenta número " + numCuenta + ": ");
                         datos = Console.ReadLine();
                         saldo = float.Parse(datos);

                     if(saldo > 0)
                     {
                       Console.WriteLine("El estado de la cuenta " + numCuenta + " es 'Acreedor'."); 
                     }
                     else if(saldo < 0)
                     {
                       Console.WriteLine("El estado de la cuenta " + numCuenta + " es 'Deudor'.");
                     }
                     else
                     {
                       Console.WriteLine("El estado de la cuenta " + numCuenta + " es 'Nulo'.");
                     }
                suma = suma + saldo;
                }
            }
            while (numCuenta > 0);
            if (numCuenta < 0)
            {
                Console.WriteLine("Error, la cuenta ingresada es inválida.");
            }
            Console.WriteLine("El saldo acreedor total es de " + suma + " pesos.");


        }
    }
}
