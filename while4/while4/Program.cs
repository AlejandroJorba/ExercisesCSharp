using System;

namespace while4
{
    class Program
    {
        static void Main(string[] args)
        {
            int termino = 25;
            int suma = 11;
            int x = 1;

            while (x <= termino)
            {
                Console.WriteLine(suma);
                suma = suma + 11;
                x++;
            }
        }
    }
}
