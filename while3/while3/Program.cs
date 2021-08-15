using System;

namespace while3
{
    class Program
    {
        static void Main(string[] args)
        {
            int empleados;
            float sueldo;
            int sueldoBajo = 0;
            int sueldoAlto = 0;
            string datos;
            int x = 1;
            float gasto = 0;
            Console.Write("Ingrese la cantidad de empleados que tiene su empresa: ");
            datos = Console.ReadLine();
            empleados = int.Parse(datos);

            while (x <= empleados)
            {
               Console.WriteLine("Ingrese el sueldo del empleado " + x + ": ");
               datos = Console.ReadLine();
               sueldo = float.Parse(datos);
               if(sueldo >= 100 && sueldo <= 500) { 
                    if (sueldo >= 100 && sueldo <= 300)
                        {
                        sueldoBajo++;
                        }
                            else if (sueldo > 300)
                            {
                                sueldoAlto++;
                            }
                    gasto = gasto + sueldo;
                    x++;
                }

               else
                {
                  Console.Write("El sueldo ingresado es incorrecto, vuelva a ingresar nuevamente");
                }
            }
            Console.WriteLine("Hay " + sueldoBajo + " empleados que cobran un sueldo entre 100 y 300 pesos.");
            Console.WriteLine("Hay " + sueldoAlto + " empleados que cobran un sueldo mayor a 300 pesos.");

            Console.WriteLine("La empresa gasta en sueldos " + gasto + " pesos.");

        }
    }
}
