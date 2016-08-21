using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_12
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 12";

            int acumulador = 0;

            do
            {
                Console.Write("Ingrese numero entero: ");
                acumulador += int.Parse(Console.ReadLine());
            } while (ValidarRespuesta.ValidaS_N());

            Console.Write("La suma total es de {0}", acumulador);

            Console.ReadKey();
        }
    }
}
