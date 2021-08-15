using System;

namespace doWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            string datos;
            float suma = 0;
            do{
                Console.Write("Ingrese un número para ser sumado: ");
                datos = Console.ReadLine();
                num = float.Parse(datos);

                     if(num != 9999 && num != -9999)
                     {
                        suma = suma + num;
                     }

                } while (num != 9999 && num != -9999);

            Console.WriteLine("El valor total ingresado es: " + suma);
            if(suma > 0)
            {
                Console.WriteLine("El valor ingresado es mayor a 0");
            }
            else if(suma < 0)
            {
                Console.WriteLine("El valor ingresado es menor a 0");
            }
            else
            {
                Console.WriteLine("El valor ingresado es 0");
            }
        }
    }
}
