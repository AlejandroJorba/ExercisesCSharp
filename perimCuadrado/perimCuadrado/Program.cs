using System;

namespace perimCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {

            float ancho;
            float largo;
            string datos;

            Console.Write("Ingrese el ancho del cuadrado en cm: ");
            datos = Console.ReadLine();
            ancho = float.Parse(datos);

            Console.Write("Ingrese el largo del cuadrado en cm: ");
            datos = Console.ReadLine();
            largo = float.Parse(datos);

            float perim = (ancho * 2) + (largo * 2);
            Console.WriteLine("El perímetro del cuadrado es de: " + perim + " cm");
        }
    }
}
