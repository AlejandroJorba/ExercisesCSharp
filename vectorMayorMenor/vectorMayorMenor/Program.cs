using System;

namespace vectorMayorMenor
{
    class VectorMayorMenor
    {
        private string[] aulas;
        private int[] alumnos;
        private string datos;
        private int cant;

        public void cargarDatos()
        {
            Console.Write("Ingrese la cantidad de aulas a ingresar: ");
            datos = Console.ReadLine();
            cant = int.Parse(datos);
            aulas = new string[cant];
            alumnos = new int[cant];
            for (int x = 0; x < aulas.Length; x++)
            {
                Console.Write("Ingrese el aula " + (x + 1) + ": ");
                datos = Console.ReadLine();
                aulas[x] = datos;

                Console.Write("Ingrese la cantidad de alumnos del aula " + aulas[x] + ": ");
                datos = Console.ReadLine();
                alumnos[x] = int.Parse(datos);
            }
            
        }

        public void mayorMenor()
        {
            int mayor = alumnos[0];
            int pos = 0;
            for (int x = 0; x < aulas.Length; x++)
            {
                if(alumnos[x] > mayor)
                {
                    mayor = alumnos[x];
                    pos = x;
                }
            }
            Console.WriteLine("El aula con más alumnos es el aula " + aulas[pos] + " con " + mayor + " alumnos.");
        }

        static void Main(string[] args)
        {
            VectorMayorMenor vec = new VectorMayorMenor();
            vec.cargarDatos();
            vec.mayorMenor();
        }
    }
}
