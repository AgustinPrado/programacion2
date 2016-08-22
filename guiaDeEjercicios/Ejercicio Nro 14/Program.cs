using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_14
{
    class Program
    {
        static void Main()
        {
            double lado;
            double b, altura;
            double radio;

            Console.Title = "Ejercicio Nro 14";
            Console.Write("Ingrese el lado del cuadrado: ");
            lado = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la base del triángulo: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el radio del círculo: ");
            radio = double.Parse(Console.ReadLine());

            Console.Write("Áreas:\nCuadrado: {0:#,###.00}\nTriángulo: {1:#,###.00}\nCírculo: {2:#,###.00}",
                CalculoDeArea.CalcularCuadrado(lado),
                CalculoDeArea.CalcularTriangulo(b, altura),
                CalculoDeArea.CalcularCirculo(radio));

            Console.ReadKey();

        }
    }
}
