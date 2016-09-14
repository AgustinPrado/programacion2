using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Program
    {
        static void Main()
        {
            /*
             * CLASE 10
             * Polimorfismo: manipulacion de objetos que tienen algo en comun y tienen una relacion de herencia.
             * El constructor no se hereda.
             * Si es privado no puedo ver lo que se hereda.
             * Herencia no hereda constructores.
             * */

            Factura miFactura = new Factura(123);
            Remito miRemito = new Remito(456);
            FacturaA miFacturaA = new FacturaA(21, miFactura);
            FacturaAPagada miFacturaAPagada = new FacturaAPagada("14/09/2016", miFacturaA);

            List<Documento> miListado = new List<Documento>();

            miListado.Add(miFactura);
            miListado.Add(miRemito);

            foreach (Factura item in miListado)
            {
                item.Mostrar();
            }

            Console.ReadKey();
            
        }
    }
}
