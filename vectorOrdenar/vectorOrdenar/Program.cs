using System;

namespace vectorOrdenar
{
    class VectorOrdenar
    {
        float[] sueldos;
        float aux;
        string datos;
        int cant;

        public void cargarSueldos()
        {

            Console.Write("Ingrese la cantidad de sueldos que va a ingresar: ");
            datos = Console.ReadLine();
            cant = int.Parse(datos);
            sueldos = new float[cant];

            for(int x = 0; x < sueldos.Length; x++)
            {
                Console.Write((x+1) + ". Ingrese el sueldo del empleado: ");
                datos = Console.ReadLine();
                sueldos[x] = float.Parse(datos);
            }
        }

        public void ordenarSueldos()
        {
            for (int y= 0; y < (sueldos.Length - 1); y++)
            {
                for (int x = 0; x < (sueldos.Length - 1); x++)
                {
                    if (sueldos[x] > sueldos[x + 1])
                    {
                        aux = sueldos[x];
                        sueldos[x] = sueldos[x + 1];
                        sueldos[x + 1] = aux;
                    }
                }
            }
        }
        public void mostrarSueldos()
        {
            Console.WriteLine("A continuación se mostrarán los sueldos de menor a mayor.");
            for (int x = 0; x < sueldos.Length; x++)
            {
                
                Console.WriteLine((x+1) + ". " + sueldos[x] + " pesos.");
            }
        }
        static void Main(string[] args)
        {
            VectorOrdenar vec = new VectorOrdenar();
            vec.cargarSueldos();
            vec.ordenarSueldos();
            vec.mostrarSueldos();
        }
    }
}
