using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class FacturaAPagada : FacturaA
    {
        public string FechaDePago;

        public FacturaAPagada(string fechaDePago, FacturaA unaFacturaA)
            : base(unaFacturaA.Iva, unaFacturaA)
        {
            this.FechaDePago = fechaDePago;
        }
    }
}
