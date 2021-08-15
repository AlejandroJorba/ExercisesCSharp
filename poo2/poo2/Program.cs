using System;

namespace poo2
{
    class Operaciones
    {
        int num1;
        int num2;
        int calculo;
        string datos;

        public void suma()
        {
            calculo = num1 + num2;
            Console.WriteLine("El resultado de la suma es " + calculo);
        }

        public void resta()
        {
            calculo = num1 - num2;
            Console.WriteLine("El resultado de la resta es " + calculo);
        }

        public void multiplicacion()
        {
            calculo = num1 * num2;
            Console.WriteLine("El resultado de la multiplicación es " + calculo);
        }

        public void divi()
        {
            calculo = num1 / num2;
            Console.WriteLine("El resultado de la división es " + calculo);
        }
        public void cargaDatos()
        {
            Console.Write("Ingrese el primer número: ");
            datos = Console.ReadLine();
            num1 = int.Parse(datos);

            Console.Write("Ingrese el segundo número: ");
            datos = Console.ReadLine();
            num2 = int.Parse(datos);
        }
        static void Main(string[] args)
        {
            Operaciones operacion1 = new Operaciones();
            operacion1.cargaDatos();
            operacion1.suma();
            operacion1.resta();
            operacion1.multiplicacion();
            
            if(operacion1.num2 > 0)
            {
                operacion1.divi();
            }
            else
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
        }
    }
}
