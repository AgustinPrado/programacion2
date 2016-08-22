using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_15
{
    public class Calculadora
    {
        public static double Calcular(double numero1, double numero2, char operacion)
        {
            switch(operacion)
            {
                case '+':
                    return numero1 + numero2;
                case '-':
                    return numero1 - numero2;
                case '*':
                    return numero1 * numero2;
                case '/':
                    if (Validar(numero2))
                        return numero1 / numero2;
                    return 0;
                default:
                    Console.WriteLine("SE INGRESÓ UN OPERADOR INCORRECTO. EL RESULTADO SERÁ 0.");
                    return 0;
            }
        }

        private static bool Validar(double divisor)
        {
            if (divisor != 0)
                return true;
            return false;
        }

        public static void Mostrar(double resultado)
        {
            Console.WriteLine("El resultado de la operación es: {0:#,###.00}",
                resultado);
            return;
        }
    }
}
