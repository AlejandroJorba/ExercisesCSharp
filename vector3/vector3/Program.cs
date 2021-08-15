using System;

namespace vector3
{
    class Vector3
    {
        int[] aula1;
        int suma1 = 0;
        int suma2 = 0;
        int[] aula2;
        string datos;
        public void cargarDatos()
        {
            aula1 = new int[5];
            aula2 = new int[5];
            Console.WriteLine("Ingrese las notas del aula 1");
            for (int x = 0; x < aula1.Length; x++)
            {
                Console.Write("Ingrese la nota del alumno " + x + ": ");
                datos = Console.ReadLine();
                aula1[x] = int.Parse(datos);
                suma1 = suma1 + aula1[x];
            }
            Console.WriteLine("Ingrese las notas del aula 2");
            for (int x = 0; x < aula2.Length; x++)
            {
                Console.Write("Ingrese la nota del alumno " + x + ": ");
                datos = Console.ReadLine();
                aula2[x] = int.Parse(datos);
                suma2 = suma2 + aula2[x];
            }
        }
        public void promedio()
        {
            int promedio1 = suma1 / aula1.Length;
            int promedio2 = suma2 / aula2.Length;
            Console.WriteLine("El promedio del curso 1 es: " + promedio1);
            Console.WriteLine("El promedio del curso 2 es: " + promedio2);
            if (promedio1 > promedio2)
            {
                Console.WriteLine("El curso 1 tiene un promedio mayor al curso 2.");
            }
            else
            {
                Console.WriteLine("El curso 2 tiene un promedio mayor al curso 1.");
            }
        }
        static void Main(string[] args)
        {
            Vector3 vec = new Vector3();
            vec.cargarDatos();
            vec.promedio();
        }
    }
}
