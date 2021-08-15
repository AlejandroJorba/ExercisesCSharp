using System;

namespace condicionalesAnidado3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string datos;

            Console.Write("Ingrese un número entero positivo de hasta 3 cifras: ");
            datos = Console.ReadLine();
            num1 = int.Parse(datos);

            if (num1 <= 9 )
            {
                Console.WriteLine("El número ingresado tiene 1 dígito");
            }
            else if (num1 >= 10 && num1 <= 99)
            {
                Console.WriteLine("El número ingresado tiene 2 dígitos");
            }
            else if (num1 >= 100 && num1 <= 999)
            {
                Console.WriteLine("El número ingresado tiene 3 dígitos");
            }
            else
            {
                Console.WriteLine("Error, el número de cifras es mayor al acordado");
            }
        }
    }
}
