using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    public class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            return Convert.ToString(Convert.ToInt32(numero), 2);
        }

        public static double BinarioDecimal(string numero)
        {
            return Convert.ToDouble(Convert.ToInt32(numero, 2));
        }
    }
}
