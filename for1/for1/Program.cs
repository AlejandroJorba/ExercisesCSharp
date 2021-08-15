using System;

namespace for1
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseTriangulo;
            int altura;
            int superficie;
            int cantidad;
            int mayor = 0;
            int i;
            string datos;

            Console.Write("Ingrese la cantidad de triangulos que va a ingresar: ");
            datos = Console.ReadLine();
            cantidad = int.Parse(datos);

            for(i = 1; i <= cantidad; i++) {

                Console.Write("Ingrese la base del triángulo " + i + ": ");
                datos = Console.ReadLine();
                baseTriangulo = int.Parse(datos);

                Console.Write("Ingrese la altura del triángulo " + i + ": ");
                datos = Console.ReadLine();
                altura = int.Parse(datos);

                superficie = baseTriangulo * altura;
                Console.WriteLine("La superficie del triángulo " + i + " es: " + superficie);

                if(superficie > 12)
                {
                    mayor++;
                }
            }
            Console.WriteLine("Hay " + mayor + " triángulo/s con una superficie mayor a 12.");
        }
    }
}
