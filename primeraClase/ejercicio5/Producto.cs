using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    public class Producto
    {
        private int _valor;

        public Producto(int numero)
        {
            this._valor = numero;
        }

        public static explicit operator Producto(int numero)
        {
            return new Producto(numero);
        }

        public static int operator +(Producto producto1, Producto producto2)
        {
            return producto1._valor + producto2._valor;
        }
    }
}
