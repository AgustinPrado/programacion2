using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    public class Pesos
    {
        private float _valor;

        public Pesos(float numero)
        {
            this._valor = numero;
        }

        public static explicit operator Pesos(float numero)
        {
            return new Pesos(numero);
        }

        public static explicit operator Dolar(Pesos numero)
        {
            return numero._valor / 15;
        }

        public static Pesos operator +(Pesos peso, Dolar dolar)
        {
            return (Pesos)(peso._valor + ((Pesos)dolar)._valor);
        }
    }
}
