using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    // pongo public para que lo pueda ver otro proyecto. Siempre se pone public o private
    public class Calculadora
    {
        // para acceder al metodo pongo el nombre de la clase y me aparece porque es static
        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Dividir(int numero1, int numero2)
        {
            if (ValidarSiEsCero(numero2))
            {
                return 0;
            }
            else
            {
                return numero1 / numero2;
            }
        }

        public static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        private static bool ValidarSiEsCero(int numero)
        {
            if (numero == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ValidarSiEsPar(int numero)
        {
            if ((numero % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Me devuelve true si el número ingresado supera el límite.
        /// </summary>
        /// <param name="numero">Este es el número que debemos verificar si supera el límite.</param>
        /// <param name="limite">Este es el límite que debe ser superado.</param>
        /// <returns></returns>
        public static bool EsMayorQue(int numero, int limite)
        {
            if (numero > limite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}