using System;

namespace vector4
{
    class Vector4
    {
        int[] vector;
        string datos;

        public void cargarDatos()
        {
            vector = new int[10];
            for(int x = 0; x < vector.Length; x++)
            {
                Console.Write("Ingrese un valor numérico para la posición " + x + ": ");
                datos = Console.ReadLine();
                vector[x] = int.Parse(datos);
            }
        }
        public void ordenar()
        {
            bool ordenado = true;
            for (int x = 0; x < 9; x++)
            {
                if (vector[x+1] < vector[x])
                {
                    ordenado = false;
                } 
            }
            if (ordenado == true)
            {
                Console.WriteLine("Está ordenado de mayor a menor.");
            }
            else
            {
                Console.WriteLine("No está ordenado de mayor a menor.");
            }
        }
        static void Main(string[] args)
        {
            Vector4 vec = new Vector4();
            vec.cargarDatos();
            vec.ordenar();
            
        }
    }
}
