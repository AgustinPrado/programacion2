using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double CalcularTriangulo(double b, double altura)
        {
            return (b * altura) / 2;
        }

        public static double CalcularCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
