using System;

namespace condicionalesAnidado4
{
    class Program
    {
        static void Main(string[] args)
        {
            int preguntasTotal;
            int preguntasCorrectas;
            int promedio;
            string datos;

            Console.Write("Ingrese la cantidad total de preguntas que contestó el empleado: ");
            datos = Console.ReadLine();
            preguntasTotal = int.Parse(datos);

            Console.Write("Ingrese la cantidad de preguntas que contestó correctamente el empleado: ");
            datos = Console.ReadLine();
            preguntasCorrectas = int.Parse(datos);

            promedio = preguntasCorrectas * 100 / preguntasTotal;
            if (promedio >= 90)
            {
                Console.WriteLine("Nivel máximo");
            }
            else if (promedio >=75 && promedio < 90)
            {
                Console.WriteLine("Nivel medio");
            }
            else if (promedio >= 50 && promedio < 75)
            {
                Console.WriteLine("Nivel regular");
            }
            else
            {
                Console.WriteLine("Fuera de nivel");
            }

        }
    }
}
