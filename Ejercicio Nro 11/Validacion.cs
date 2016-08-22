using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_11
{
    public class Validacion
    {
        public static bool Validar(int numero, int minimo, int maximo)
        {
            if ((numero >= minimo) && (numero <= maximo))
                return true;
            return false;
        }
    }
}
