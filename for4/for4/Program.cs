using System;

namespace for4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num;
            int resultado;
            string datos;
            Console.Write("Ingrese el número que desea multiplicar: ");
            datos = Console.ReadLine();
            num = int.Parse(datos);

            for (i = 1; i <= 13; i++)
            {
                resultado = num * i;
                Console.WriteLine(resultado);
            }
        }
    }
}
