using System;

namespace condicionalesAnidado1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float num3;
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

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El número " + num1 + " es el mayor de los números ingresados.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El número " + num2 + " es el mayor de los números ingresados.");
            }
            else
            {
                Console.WriteLine("El número " + num3 + " es el mayor de los números ingresados.");
            }
        }
    }
}
