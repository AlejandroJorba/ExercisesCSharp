using System;

namespace vectorParalelo1
{
    class VectorParalelo
    {
        string[] nombres;
        int[] edades;
        int cant;
        string datos;
        public void cargarDatos()
        {
            Console.Write("Ingrese la cantidad de alumnos que va a ingresar: ");
            datos = Console.ReadLine();
            cant = int.Parse(datos);
            nombres = new string[cant];
            edades = new int[cant];
            for(int x = 0; x < nombres.Length; x++) { 
            Console.Write("Ingrese el nombre del alumno " + (x+1) + ": ");
            datos = Console.ReadLine();
            nombres[x] = datos;

            Console.Write("Ingrese la edad del alumno " + (x+1) + ": ");
            datos = Console.ReadLine();
            edades[x] = int.Parse(datos);
            }
        }

        public void mostrarDatos()
        {
            for(int x = 0; x < nombres.Length; x++)
            {
                Console.WriteLine("El alumno " + nombres[x] + " tiene " + edades[x] + " años.");
            }
        }
        static void Main(string[] args)
        {
            VectorParalelo vec = new VectorParalelo();
            vec.cargarDatos();
            vec.mostrarDatos();
        }
    }
}
