using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_16
{
    class Program
    {
        static void Main()
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            Console.Title = "Ejercicio Nro 16";

            alumno1.nombre = "Agus";
            alumno1.apellido = "Prado";
            alumno1.legajo = 104303;

            alumno1.Estudiar(9, 5);

            alumno1.CalcularFinal();

            alumno1.Mostrar();

            Console.ReadKey();
        }
    }
}
