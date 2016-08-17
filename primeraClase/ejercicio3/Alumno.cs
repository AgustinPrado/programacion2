using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    public class Alumno
    {
        // como no tiene la palabra STATIC, es de instancia.
        public string Nombre;
        public int Nota;

        public void MostrarDatos()
        {
            // uso THIS porque estoy hablando de esta instancia.
            Console.WriteLine("\nNombre: " + this.Nombre);
            Console.WriteLine("Nota: " + this.Nota);
        }

        // cuando lo pienso por Clase, static
        public static bool CompararAlumnos(Alumno uno, Alumno dos)
        {
            if (uno.Nombre == dos.Nombre)
                return true;
            return false;

            /*
             * returno uno.Compararme(dos);
             */
        }

        // metodo de instancia
        public bool Compararme(Alumno otro)
        {
            if (this.Nombre == otro.Nombre)
                return true;
            return false;

            /*
             * return CompararAlumnos(this, otro); USAR ESTO, REUTILIZAR CODIGO
             */
        }
    }
}
