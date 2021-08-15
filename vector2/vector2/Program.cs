using System;

namespace vector2
{
    class Vector2
    {
        int[] vec1;
        int[] vec2;
        int[] vecSuma;
        string datos;
        public void cargaVector1()
        {
            vec1 = new int[4];
            Console.WriteLine("Rellena los datos del vector 1");
            for (int x = 0; x < vec1.Length; x++)
            {
                Console.Write("Ingrese un valor númerico para la posición " + x + ":");
                datos = Console.ReadLine();
                vec1[x] = int.Parse(datos);
            }

        }

        public void cargaVector2()
        {
            vec2 = new int[4];
            Console.WriteLine("Rellena los datos del vector 2");
            for (int x = 0; x < vec2.Length; x++)
            {
                Console.Write("Ingrese un valor númerico para la posición " + x + ":");
                datos = Console.ReadLine();
                vec2[x] = int.Parse(datos);
            }

        }

        public void sumaVectores()
        {
            vecSuma = new int[4];
            int total = 0;
            for (int x = 0; x < vecSuma.Length; x++)
            {
                vecSuma[x] = vec1[x] + vec2[x];
                total = total + vec1[x] + vec2[x];
            }
            Console.WriteLine("Suma entre vectores");
            for(int x = 0; x < vecSuma.Length; x++)
            {
                Console.WriteLine(vecSuma[x]);
            }
            Console.WriteLine("El valor total entre los valores de ambos arrays es " + total);
        }
        static void Main(string[] args)
        {
            Vector2 vec = new Vector2();
            vec.cargaVector1();
            vec.cargaVector2();
            vec.sumaVectores();
        }
    }
}
