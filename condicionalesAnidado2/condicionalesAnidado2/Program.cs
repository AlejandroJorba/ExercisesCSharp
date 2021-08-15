using System;

namespace condicionalesAnidado2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string datos;

            Console.Write("Ingrese un número entero: ");
            datos = Console.ReadLine();
            num1 = int.Parse(datos);
            
            if (num1 > 0)
            {
                Console.WriteLine("El número es positivo");
            }
            else if(num1 < 0)
            {
                Console.WriteLine("El número es negativo");
            }
            else
            {
                Console.WriteLine("El número es nulo");
            }

        }
    }
}
