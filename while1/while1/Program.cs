using System;

namespace while1
{
    class Program
    {
        static void Main(string[] args)
        {
            int aprobados = 0;
            int desaprobados = 0;
            float nota;
            string datos;
            int x = 1;
            while (x <= 10)
            {
                Console.Write("Ingrese la nota número " + x + " del alumno: ");
                datos = Console.ReadLine();
                nota = float.Parse(datos);
                if(nota >= 7)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
                x++;
            }

            Console.WriteLine(aprobados + " alumnos aprobaron la materia.");
            Console.WriteLine(desaprobados + " alumnos desaprobaron la materia.");

        }
    }
}
