using System;

namespace while6
{
    class Program
    {
        static void Main(string[] args)
        {
            int valores = 15;
            float suma1 = 0;
            float suma2 = 0;
            float num1;
            int x = 1;
            int y = 1;
            string datos;
            Console.WriteLine("Lista número 1");
            while (x <= valores)
            {
                Console.Write("Ingrese el valor número " + x + ": ");
                datos = Console.ReadLine();
                num1 = float.Parse(datos);

                suma1 = suma1 + num1;
                x++;
            }
            Console.WriteLine("Lista número 2");
            while (y <= valores)
            {
                Console.Write("Ingrese el valor número " + y + ": ");
                datos = Console.ReadLine();
                num1 = float.Parse(datos);

                suma2 = suma2 + num1;
                y++;
            }

            if (suma1 > suma2)
            {
                Console.WriteLine("La lista número 1 es mayor.");

            } else
            {
                if(suma2 > suma1)
                {
                    Console.WriteLine("La lista número 2 es mayor.");

                }
                else
                {
                    Console.WriteLine("Ambas listas tienen el mismo valor");

                }
            }
        }
    }
}
