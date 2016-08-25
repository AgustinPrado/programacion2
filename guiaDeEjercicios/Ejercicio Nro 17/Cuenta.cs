using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_17
{
    public class Cuenta
    {
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private ETipoInteres _tipoInteres;

        public string getNombre()
        {
            return this._nombre;
        }

        public long getNroCuenta()
        {
            return this._nroCuenta;
        }

        public double getSaldo()
        {
            return this._saldo;
        }

        public ETipoInteres getTipoInteres()
        {
            return this._tipoInteres;
        }

        public void setNombre(string nombre)
        {
            if(nombre.Length == 0)
                this._nombre = ETipoInteres.VACIO.ToString();
            else
                this._nombre = nombre;
        }

        public void setNroCuenta(long nroCuenta)
        {
            if (nroCuenta > 0)
                this._nroCuenta = nroCuenta;
            else
                this._nroCuenta = (long)ETipoInteres.VACIO;
        }

        public void setSaldo(double saldo)
        {
            if (saldo > 0)
                this._saldo = saldo;
            else
                this._saldo = (double)ETipoInteres.VACIO;
        }

        public void setTipoInteres(ETipoInteres tipoInteres)
        {
            if ((tipoInteres <= ETipoInteres.TIR) && (tipoInteres >= ETipoInteres.TIN))
                this._tipoInteres = tipoInteres;
            else
                this._tipoInteres = ETipoInteres.VACIO;
        }
    }
}
