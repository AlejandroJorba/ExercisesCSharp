using System;

namespace SumaProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            string datos;
            Console.Write("Ingrese el primer número: ");
            datos = Console.ReadLine();
            num1 = int.Parse(datos);

            Console.Write("Ingrese el segundo número: ");
            datos = Console.ReadLine();
            num2 = int.Parse(datos);

            float resultadoSuma = num1 + num2;
            Console.WriteLine("El resultado entre la suma de " + num1 + " y " + num2 + " es = " + resultadoSuma);

            float resultadoProd = num1 * num2;
            Console.WriteLine("El producto entre " + num1 + " y " + num2 + " es = " + resultadoProd);


        }
    }
}
