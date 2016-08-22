using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_15
{
    class Program
    {
        static void Main()
        {
            double numero1;
            double numero2;
            char operacion;

            Console.Title = "Ejercicio Nro 15";
            do
            {
                Console.Write("Ingrese primer numero: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese segundo numero: ");
                numero2 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese operador numero: ");
                operacion = char.Parse(Console.ReadLine());
            } while (Ejercicio_Nro_12.ValidarRespuesta.ValidaS_N());

            Calculadora.Mostrar(Calculadora.Calcular(numero1, numero2, operacion));

            Console.ReadKey();
        }
    }
}
