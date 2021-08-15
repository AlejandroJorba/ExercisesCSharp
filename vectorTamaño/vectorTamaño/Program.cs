using System;

namespace vectorTamaño
{
    class Vector
    {
        private int cant;
        private string datos;
        private int[] vector;
        public void cargarDatos()
        {
            Console.Write("Ingrese la cantidad de sueldos que ingresará: ");
            datos = Console.ReadLine();
            cant = int.Parse(datos);
            vector = new int[cant];

            for(int x = 0; x < vector.Length; x++)
            {
                Console.Write("Ingrese el sueldo del empleado " + (x+1) + ":");
                datos = Console.ReadLine();
                vector[x] = int.Parse(datos);
            }
        }
        public void mostrarDatos()
        {
            for(int x = 0; x < vector.Length; x++)
            {
                Console.WriteLine("El sueldo del empleado " + (x+1) + " es de " + vector[x] + " pesos.");
            }
        }
        static void Main(string[] args)
        {
            Vector vec = new Vector();
            vec.cargarDatos();
            vec.mostrarDatos();

        }
    }
}
