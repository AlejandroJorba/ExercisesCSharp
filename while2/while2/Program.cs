using System;

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {
            int personas;
            float altura;
            string datos;
            float suma = 0;
            float promedio;
            int x = 1;

            Console.Write("Ingrese la cantidad de personas: ");
            datos = Console.ReadLine();
            personas = int.Parse(datos);

            while (x <= personas)
            {
                Console.Write("Ingrese la altura de la persona número " + x + ": ");
                datos = Console.ReadLine();
                altura = float.Parse(datos);
                suma = suma + altura;
                x++;
            }
            promedio = suma / personas;
            Console.WriteLine("La altura promedio de las personas es de: " + promedio + " mts.");

        }
    }
}
