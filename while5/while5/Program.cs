using System;

namespace while5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8;
            int tope = 500;
            while (num <= tope)
            {
                Console.WriteLine(num);
                num = num + 8;
            }
        }
    }
}
