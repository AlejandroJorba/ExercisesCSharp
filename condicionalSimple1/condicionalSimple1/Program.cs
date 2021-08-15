using System;

namespace condicionalSimple1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float suma;
            float producto;
            float resta;
            float division;
            string datos;


            Console.Write("Ingrese el primer número: ");
            datos = Console.ReadLine();
            num1 = float.Parse(datos);
            Console.Write("Ingrese el segundo número: ");
            datos = Console.ReadLine();
            num2 = float.Parse(datos);

            if (num1 > num2)
            {
                suma = num1 + num2;
                Console.WriteLine("El valor de la suma entre ambos números es de " + suma);
                resta = num1 - num2;
                Console.WriteLine("El valor de la resta entre ambos números es de " + resta);
            }
            else
            {
                producto = num1 * num2;
                Console.WriteLine("El producto entre ambos números es " + producto);
                division = num1 / num2;
                Console.WriteLine("La division entre ambos números da como resultado " + division);
            }
        }
    }
}
