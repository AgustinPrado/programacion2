using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_2
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 02";
            float numero;
            double cuadrado;
            double cubo;

            Console.Write("\nIngrese un numero: ");
            numero = float.Parse(Console.ReadLine());
            if (numero == 0)
            {
                Console.Write("\nERROR. Reingresar número!!!");
            }
            else
            {
                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.Write("\nCuadrado: " + cuadrado);
                Console.Write("\nCubo: " + cubo);
            }
            Console.ReadKey();

        }
    }
}
