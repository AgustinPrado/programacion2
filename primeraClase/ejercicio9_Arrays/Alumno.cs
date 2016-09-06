using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9_Arrays
{
    public class Alumno
    {
        public string Nombre;
        public int Legajo;

        public Alumno(string nombre, int legajo)
        {
            this.Nombre = nombre;
            this.Legajo = legajo;
        }

        public static bool operator ==(Alumno alu1, Alumno alu2)
        {
            if (alu1.Legajo == alu2.Legajo)
                return true;
            return false;
        }

        public static bool operator !=(Alumno alu1, Alumno alu2)
        {
            return !(alu1 == alu2);
        }
    }
}
