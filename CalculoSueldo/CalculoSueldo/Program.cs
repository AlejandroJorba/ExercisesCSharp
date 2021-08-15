using System;

namespace CalculoSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float pagoHora;
            float sueldo;
            string datos;

            Console.Write("Ingrese las horas trabajadas: ");
            datos = Console.ReadLine();
            horasTrabajadas = int.Parse(datos);

            Console.Write("Ingrese el pago por hora del empleado: ");
            datos = Console.ReadLine();
            pagoHora = float.Parse(datos);

            sueldo = horasTrabajadas * pagoHora;
            Console.Write("El sueldo de su empleado es de " + sueldo + " pesos");

        }
    }
}
