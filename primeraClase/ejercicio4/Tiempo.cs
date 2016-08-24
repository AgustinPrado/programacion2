using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    public class Tiempo
    {
        public int Cantidad;

        public Tiempo(int cantidad)
        {
            this.Cantidad = cantidad;
        }

        public static Tiempo Sumar(Tiempo tiempoAux, int valor)
        {
            tiempoAux.Cantidad = tiempoAux.Cantidad + valor;



            return tiempoAux;
        }

        // sobrecargo el operador +
        public static Tiempo operator +(Tiempo tiempoAux, int valor)
        {
            tiempoAux.Cantidad = tiempoAux.Cantidad + valor;

            
            return tiempoAux;
        }
    }
}
