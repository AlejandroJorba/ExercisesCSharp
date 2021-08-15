using System;

namespace for2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            float suma = 0;
            float num;
            string datos;
            for(i=1; i <= 10; i++) {
                Console.Write("Ingrese el número " + i + ": ");
                datos = Console.ReadLine();
                num = float.Parse(datos);

                if(i > 5)
                {
                    suma = suma + num;
                }
            }
            Console.WriteLine("La suma de los últimos 5 valores ingresados es: " + suma);
        }
    }
}
