using System;

namespace _4nums
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float num3;
            float num4;
            string datos;

            Console.Write("Ingrese el primer número: ");
            datos = Console.ReadLine();
            num1 = float.Parse(datos);

            Console.Write("Ingrese el segundo número: ");
            datos = Console.ReadLine();
            num2 = float.Parse(datos);

            Console.Write("Ingrese el tercer número: ");
            datos = Console.ReadLine();
            num3 = float.Parse(datos);

            Console.Write("Ingrese el cuarto número: ");
            datos = Console.ReadLine();
            num4 = float.Parse(datos);

            float suma = num1+ num2;
            float producto = num3 * num4;

            Console.WriteLine("El resultado entre la suma de " + num1 + " + " + num2 + " es = " + suma);
            Console.WriteLine("El producto entre " + num3 + " + " + num4 + " es = " + producto);
        }
    }
}
