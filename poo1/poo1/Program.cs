using System;

namespace poo1
{
    class Empleado
    {
        private float sueldo;
        private string nombre;
        private string datos;
        
        public void cargarDatos()
        {
            Console.Write("Ingrese el nombre del empleado: ");
            datos = Console.ReadLine();
            nombre = datos;

            Console.Write("Ingrese el sueldo del empleado: ");
            datos = Console.ReadLine();
            sueldo = float.Parse(datos);
        }

        public void impuestos()
        {
            if(sueldo > 3000)
            {
                Console.WriteLine("El empleado deberá pagar impuestos.");
            }
            else
            {
                Console.WriteLine("El empleado no tiene que pagar impuestos.");
            }
        }

        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.cargarDatos();
            empleado1.impuestos();
            
        }
    }
}
