using System;

namespace vectorParaleloOrdenar
{
    class Vector
    {
        private string[] paises;
        private int[] habitantes;
        private string datos;
        private int cant;
        private int auxHabitante;
        private string auxPais;
        public void cargarDatos()
        {
            Console.Write("Ingrese la cantidad de países que desea ingresar: ");
            datos = Console.ReadLine();
            cant = int.Parse(datos);
            paises = new string[cant];
            habitantes = new int[cant];

            for(int x = 0; x < paises.Length; x++) { 
                Console.Write((x+1) + ". Coloque el nombre del país que desea ingresar: ");
                datos = Console.ReadLine();
                paises[x] = datos;
                Console.Write((x + 1) + ". Coloque la cantidad de habitantes del país: ");
                datos = Console.ReadLine();
                habitantes[x] = int.Parse(datos);
            }
        }

        public void ordenarAlfab()
        {
            for(int y = 0; y < (paises.Length-1); y++)
            {
                for(int x = 0; x < (paises.Length-1); x++)
                {
                    if (paises[x].CompareTo(paises[x+1]) > 0)
                    {
                        auxPais = paises[x];
                        paises[x] = paises[x + 1];
                        paises[x + 1] = auxPais;

                        auxHabitante = habitantes[x];
                        habitantes[x] = habitantes[x + 1];
                        habitantes[x + 1] = auxHabitante;
                    }
                }
            }
        }

       public void ordenarCantidad()
        {
            for(int y = 0; y < (paises.Length - 1); y++)
            {
                for (int x = 0; x < (paises.Length - 1); x++)
                {
                    if (habitantes[x] < habitantes[x+1])
                    {
                        auxPais = paises[x];
                        paises[x] = paises[x + 1];
                        paises[x + 1] = auxPais;

                        auxHabitante = habitantes[x];
                        habitantes[x] = habitantes[x + 1];
                        habitantes[x + 1] = auxHabitante;
                    }
                }
            }
        }
       
        public void mostrarDatos()
        {
            
            for (int x = 0; x < paises.Length; x++)
            {
                Console.WriteLine((x + 1) + ". " + paises[x] + " cuenta con " + habitantes[x] + " habitantes.");
            }

        }
        static void Main(string[] args)
        {
            Vector vec = new Vector();
            vec.cargarDatos();
            vec.ordenarAlfab();
            Console.WriteLine("A continuación se muestran los países ordenados alfabéticamente");
            vec.mostrarDatos();
            vec.ordenarCantidad();
            Console.WriteLine("A continuación se muestran los países ordenados por cantidad de habitantes");
            vec.mostrarDatos();
        }
    }
}
