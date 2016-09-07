using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    public class Tiempo
    {
        private int _cantidad;

        private Tiempo(int cantidad)
        {
            this._cantidad = cantidad;
        }

        #region DEPRECATED por sobrecarga de operador
        /*
        public static Tiempo Sumar(Tiempo tiempoAux, int valor)
        {
            tiempoAux.Cantidad = tiempoAux.Cantidad + valor;

            return tiempoAux;
        }
         */
        #endregion

        #region SOBRECARGA DE OPERADORES
        // sobrecargo el operador +
        public static Tiempo operator +(Tiempo tiempoAux, int valor)
        {
            tiempoAux._cantidad = tiempoAux._cantidad + valor;

            return tiempoAux;
        }

        public static Tiempo operator +(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (tiempo1 + tiempo2._cantidad);
        }

        public static Tiempo operator -(Tiempo tiempoAux, int valor)
        {
            tiempoAux._cantidad = tiempoAux._cantidad - valor;

            return tiempoAux;
        }

        public static Tiempo operator -(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (tiempo1 - tiempo2._cantidad);
        }

        public static bool operator ==(Tiempo tiempoAux, int valor)
        {
            return (tiempoAux._cantidad == valor);
        }

        public static bool operator ==(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (tiempo1 == tiempo2._cantidad);
        }

        public static bool operator !=(Tiempo tiempoAux, int valor)
        {
            return !(tiempoAux == valor);
        }

        public static bool operator !=(Tiempo tiempo1, Tiempo tiempo2)
        {
            return !(tiempo1 == tiempo2);
        }

        public static bool operator <(Tiempo tiempoAux, int valor)
        {
            return (tiempoAux._cantidad < valor);
        }

        public static bool operator <(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (tiempo1 < tiempo2._cantidad);
        }

        public static bool operator >(Tiempo tiempoAux, int valor)
        {
            return (tiempoAux._cantidad > valor);
        }

        public static bool operator >(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (tiempo1 > tiempo2._cantidad);
        }
        #endregion

        #region SOBRECARGA DE CASTEO
        public static implicit operator Tiempo(int numero)
        {
            return new Tiempo(numero);
        }

        public static explicit operator int(Tiempo tiempo)
        {
            return tiempo._cantidad;
        }
        #endregion


    }
}
