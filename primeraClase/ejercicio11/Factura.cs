using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Factura : Documento
    {
        public float Importe;

        public Factura(int numero)
            : base(numero)
        { 
        }

        public Factura(int numero, string fecha, int numeroDeControl)
            : base(numero, fecha, numeroDeControl)
        {
        }
        
    }
}
