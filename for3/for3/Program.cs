using System;

namespace for3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int resultado = 0;
            for(i = 1; resultado < 50; i++)
            {
                resultado = 5 * i;
                Console.WriteLine(resultado);
            }
        }
    }
}
