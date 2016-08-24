using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_16
{
    public class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;
        private static Random randomFinal;

        static Alumno()
        {
            Alumno.randomFinal = new Random();
        }

        public void CalcularFinal()
        {
            if ((this._nota1 >= 4) && (this._nota2 >= 4))
                this._notaFinal = Alumno.randomFinal.Next(1, 11);
            else
                this._notaFinal = -1;
        }

        public void Estudiar(byte notaUna, byte notaDos)
        {
            this._nota1 = notaUna;
            this._nota2 = notaDos;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} {1} con legajo {2} obtuvo en los parciales las notas {3} y {4}.",
                this.nombre,
                this.apellido,
                this.legajo,
                this._nota1,
                this._nota2);
            if(this._notaFinal != -1)
                Console.WriteLine("La nota del final es {0}.", this._notaFinal);
        }

    }
}
