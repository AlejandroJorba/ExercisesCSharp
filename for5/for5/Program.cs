using System;

namespace for5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int lado;
            int cantidad;
            string datos;
            int lado1;
            int lado2;
            int lado3;
            int equilateros = 0;
            int escalenos = 0;
            int isosceles = 0;

            Console.Write("Ingrese la cantidad de triángulos que va a ingresar: ");
            datos = Console.ReadLine();
            cantidad = int.Parse(datos);

            for(i = 1; i <= cantidad; i++)
            {
                Console.Write("Ingrese el lado 1: ");
                datos = Console.ReadLine();
                lado1 = int.Parse(datos);

                Console.Write("Ingrese el lado 2: ");
                datos = Console.ReadLine();
                lado2 = int.Parse(datos);

                Console.Write("Ingrese el lado 3: ");
                datos = Console.ReadLine();
                lado3 = int.Parse(datos);
                Console.WriteLine("--------------------------- ");

                if (lado1 == lado2 && lado1 == lado3)
                {
                    equilateros++;
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    isosceles++;
                }
                else
                {
                    escalenos++;
                }
            }

            Console.WriteLine("Hay " + equilateros + " triángulos equilateros.");
            Console.WriteLine("Hay " + isosceles + " triángulos isósceles.");
            Console.WriteLine("Hay " + escalenos + " triángulos escalenos.");

            if (equilateros < isosceles && equilateros < escalenos)
            {
                Console.WriteLine("Hay menor cantidad de triángulos equilateros.");

            } else
            {
                if(isosceles < escalenos)
                {
                    Console.WriteLine("Hay menor cantidad de triángulos isósceles.");
                }
                else
                {
                    Console.WriteLine("Hay menor cantidad de triángulos escalenos.");

                }
            }

        }
    }
}
