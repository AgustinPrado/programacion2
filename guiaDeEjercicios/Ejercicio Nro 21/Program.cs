using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monedas;

namespace Ejercicio_Nro_21
{
    class Program
    {
        static void Main()
        {
            Dolar dolar = new Monedas.Dolar(1);
            Euro euro = new Monedas.Euro(3);

            dolar = dolar + euro;
            dolar = dolar + 4;

            // preguntar sobre implicit y explicit
            // no se puede de igual firma obtener distintos resultados

            Console.WriteLine("Dolar es {0}", dolar.Cantidad);

            Console.ReadKey();

        }
    }
}
