using System;

namespace array1
{
    class Vector1
    {
        private int[] elementos;

        public void cargarDatos()
        {
            elementos = new int[8];
            string datos;
            for (int x = 0; x < elementos.Length; x++)
            {
                Console.Write("Ingrese el elemento número " + x + ": ");
                datos = Console.ReadLine();
                elementos[x] = int.Parse(datos);
            }
        }

        public void sumaValor()
        {
            int suma = 0;
            for(int x = 0; x < elementos.Length; x++)
            {
                suma = suma + elementos[x];
            }
            Console.WriteLine("La suma total de todos los valores es " + suma);
        }

        public void mayor36()
        {
            int suma = 0;
            for (int x = 0; x < elementos.Length; x++)
            {   
                if(elementos[x] > 36) { 
                suma = suma + elementos[x];
                }
            }
            Console.WriteLine("La suma total de los valores mayores a 36 es " + suma);
        }

        public void mayor50()
        {
            int cant = 0;
            for (int x = 0; x < elementos.Length; x++)
            {
                if (elementos[x] > 50)
                {
                    cant++;
                }
            }
            Console.WriteLine("Hay " + cant + " elementos mayores de 50.");
        }

        static void Main(string[] args)
        {

            Vector1 vec = new Vector1();
            vec.cargarDatos();
            vec.sumaValor();
            vec.mayor36();
            vec.mayor50();
            
        }
    }
}
