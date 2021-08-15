using System;

namespace while7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int pares = 0;
            int impares = 0;
            int num;
            int numeros;
            string datos;
            Console.Write("Escribe la cantidad de números que deseas ingresar: ");
            datos = Console.ReadLine();
            numeros = int.Parse(datos);
            
            while(x <= numeros)
            {
                Console.Write("Ingrese el número " + x + ": ");
                datos = Console.ReadLine();
                num = int.Parse(datos);
                if(num % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                x++;

            }

            Console.WriteLine("Se han ingresado " + pares + " número/s par.");
            Console.WriteLine("Se han ingresado " + impares + " número/s impar.");

        }
    }
}
