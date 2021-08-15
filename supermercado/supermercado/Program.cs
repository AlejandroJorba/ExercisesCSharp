using System;

namespace supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            float precio;
            int cantidad;
            float precioTotal;
            string datos;

            Console.Write("Ingrese el nombre del cliente: ");
            datos = Console.ReadLine();
            nombre = datos;
            Console.Write("Ingrese el valor de producto: ");
            datos = Console.ReadLine();
            precio = float.Parse(datos);
            Console.Write("Ingrese la cantidad que va a llevar: ");
            datos = Console.ReadLine();
            cantidad = int.Parse(datos);

            precioTotal = precio * cantidad;
            Console.WriteLine("El cliente " + nombre + " lleva " + cantidad + " artículos por el valor de " + precio + " pesos y deberá abonar " + precioTotal + " pesos.");
        }
    }
}
