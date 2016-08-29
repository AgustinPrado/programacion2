using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    public class Dolar
    {
        public double Cantidad;

        public Dolar(double valor)
        {
            this.Cantidad = valor;
        }

        public static Dolar operator +(Dolar dolarAux, Euro euroAux)
        {
            dolarAux.Cantidad = dolarAux.Cantidad + (euroAux.Cantidad * 1.3642);
            
            return dolarAux;
        }

        public static Dolar operator +(Dolar dolarAux, double valor)
        {
            dolarAux.Cantidad = dolarAux.Cantidad + valor;

            return dolarAux;
        }

        public static Dolar operator -(Dolar dolarAux, Euro euroAux)
        {
            dolarAux.Cantidad = dolarAux.Cantidad - (euroAux.Cantidad / 1.3642);

            return dolarAux;
        }

        public static Dolar operator -(Euro euroAux, Dolar dolarAux)
        {
            dolarAux.Cantidad = (euroAux.Cantidad / 1.3642) - dolarAux.Cantidad;

            return dolarAux;
        }

        public static Dolar operator -(Dolar dolarAux, double valor)
        {
            dolarAux.Cantidad = dolarAux.Cantidad - valor;

            return dolarAux;
        }

        public static Dolar operator -(double valor, Dolar dolarAux)
        {
            dolarAux.Cantidad = valor - dolarAux.Cantidad;

            return dolarAux;
        }

        public static Dolar operator ++(Dolar dolarAux)
        {
            dolarAux = dolarAux + 1;

            return dolarAux;
        }

        public static Dolar operator --(Dolar dolarAux)
        {
            dolarAux = dolarAux + (-1);

            return dolarAux;
        }

    }
}
