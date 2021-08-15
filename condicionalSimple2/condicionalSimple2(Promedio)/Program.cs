using System;

namespace condicionalSimple2_Promedio_
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1;
            float nota2;
            float nota3;
            float promedio;
            float notas;
            string datos;

            Console.Write("Ingrese la primer nota: ");
            datos = Console.ReadLine();
            nota1 = float.Parse(datos);
            Console.Write("Ingrese la segunda nota: ");
            datos = Console.ReadLine();
            nota2 = float.Parse(datos);
            Console.Write("Ingrese la tercer nota: ");
            datos = Console.ReadLine();
            nota3 = float.Parse(datos);

            notas = nota1 + nota2 + nota3;
            promedio = notas / 3;
            if (promedio >= 7)
            {
                Console.WriteLine("Estás promociondo");
            }
            else
            {
                Console.WriteLine("Solo tenías que seguir el tren");
            }
        }
    }
}
