using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Documento
    {
        public int Numero;
        public string _fecha;
        public int _numeroDeControl;

        public Documento(int numero)
        {
            this.Numero = numero;
        }

        public Documento(int numero, string fecha, int numeroDeControl)
            : this(numero)
        {
            this._fecha = fecha;
            this._numeroDeControl = numeroDeControl;
        }

        public void Mostrar()
        {
            Console.WriteLine(this.Numero);
        }
    }
}
