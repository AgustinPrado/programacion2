using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    public class Dolar
    {
        private float _valor;

        public Dolar(float numero)
        {
            this._valor = numero;
        }

        public static implicit operator Dolar(float numero)
        {
            return new Dolar(numero);
        }

        public static explicit operator Pesos(Dolar numero)
        {
            return (Pesos)(numero._valor * 15);
        }

        public static Dolar operator +(Dolar dolar, Pesos peso)
        {
            return (Dolar)(dolar._valor + ((Dolar)peso)._valor);
        }
    }
}
