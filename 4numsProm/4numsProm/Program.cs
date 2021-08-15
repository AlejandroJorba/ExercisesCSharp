using System;

namespace _4numsProm
{
    class Program
    {
        static void Main(string[] args)
        {

            float nota1;
            float nota2;
            float nota3;
            float nota4;
            float notas;
            float promedio;
            string datos;

            Console.Write("Ingrese la primera nota del alumno: ");
            datos = Console.ReadLine();
            nota1 = float.Parse(datos);
            Console.Write("Ingrese la segunda nota del alumno: ");
            datos = Console.ReadLine();
            nota2 = float.Parse(datos);
            Console.Write("Ingrese la tercera nota del alumno: ");
            datos = Console.ReadLine();
            nota3 = float.Parse(datos);
            Console.Write("Ingrese la cuarta nota del alumno: ");
            datos = Console.ReadLine();
            nota4 = float.Parse(datos);

            notas = nota1 + nota2 + nota3 + nota4;
            promedio = notas / 4;

            Console.WriteLine("La sumatoria de las notas da " + notas + " y el promedio es de " + promedio);

        }
    }
}
