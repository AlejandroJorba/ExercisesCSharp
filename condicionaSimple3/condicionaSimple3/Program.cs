using System;

namespace condicionaSimple3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string datos;
            Console.WriteLine("Ingrese un número para saber si tiene 1 o más dígitos:  ");
            datos = Console.ReadLine();
            num1 = int.Parse(datos);
            
            if (num1 >= 10)
            {
                Console.WriteLine("El número tiene más de 1 dígito");
            }
            else
            {
                Console.WriteLine("El número tiene 1 dígito");
            }
        }
    }
}
