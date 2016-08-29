using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    public class Euro
    {
        public double Cantidad;

        public Euro(double valor)
        {
            this.Cantidad = valor;
        }
        
        public static Euro operator +(Euro euroAux, Dolar dolarAux)
        {
            euroAux.Cantidad = (dolarAux.Cantidad / 1.3642) + euroAux.Cantidad;

            return euroAux;
        }
        

        public static Euro operator +(Euro euroAux, double valor)
        {
            euroAux.Cantidad = euroAux.Cantidad + valor;

            return euroAux;
        }

        public static Euro operator -(Dolar dolarAux, Euro euroAux)
        {
            euroAux.Cantidad = (dolarAux.Cantidad * 1.3642) - euroAux.Cantidad;

            return euroAux;
        }

        public static Euro operator -(Euro euroAux, double valor)
        {
            euroAux.Cantidad = euroAux.Cantidad - valor;

            return euroAux;
        }

        public static Euro operator ++(Euro euroAux)
        {
            euroAux = euroAux + 1;

            return euroAux;
        }

        public static Euro operator --(Euro euroAux)
        {
            euroAux = euroAux + (-1);

            return euroAux;
        }
    }
}
