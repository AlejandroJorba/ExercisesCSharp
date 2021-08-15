using System;

namespace for8
{
    class Program
    {
        static void Main(string[] args)
        {
            int promedio1;
            int promedio2;
            int promedio3;
            int edad;
            int suma1 = 0;
            int suma2 = 0;
            int suma3 = 0;
            int i;
            string datos;

            Console.WriteLine("Ingrese las edades de los alumnos del turno mañana");
            for(i = 1; i <= 50; i++)
            {
                Console.Write("Ingrese la edad del alumno " + i + ": ");
                datos = Console.ReadLine();
                edad = int.Parse(datos);

                suma1 = suma1 + edad;
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Ingrese las edades de los alumnos del turno tarde");
            for (i = 1; i <= 60; i++)
            {
                Console.Write("Ingrese la edad del alumno " + i + ": ");
                datos = Console.ReadLine();
                edad = int.Parse(datos);

                suma2 = suma2 + edad;
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Ingrese las edades de los alumnos del turno noche");
            for (i = 1; i <= 110; i++)
            {
                Console.Write("Ingrese la edad del alumno " + i + ": ");
                datos = Console.ReadLine();
                edad = int.Parse(datos);

                suma3 = suma3 + edad;
             }
            promedio1 = suma1 / 50;
            promedio2 = suma2 / 60;
            promedio3 = suma3 / 110;
            Console.WriteLine("El promedio del turno mañana es de " + promedio1 + " años.");
            Console.WriteLine("El promedio del turno tarde es de " + promedio2 + " años.");
            Console.WriteLine("El promedio del turno noche es de " + promedio3 + " años.");
            if (promedio1 < promedio2 && promedio1 < promedio3)
            {
                Console.WriteLine("El promedio del turno mañana es menor.");
            } else
            {
                if (promedio2 < promedio3)
                {
                    Console.WriteLine("El promedio del turno tarde es menor.");
                }
                else
                {
                    Console.WriteLine("El promedio del turno noche es menor.");
                }
            }
        }
    }
}
