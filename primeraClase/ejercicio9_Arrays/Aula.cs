using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9_Arrays
{
    public class Aula
    {
        public int Numero;
        public Alumno[] ListaDeAlumnos;

        public Aula()
        {
            this.ListaDeAlumnos = new Alumno[10];
            /*
             * NO LO VAMOS A USAR NUNCA :)
            for (int i = 0; i < this.ListaDeAlumnos.Length; i++)
            {
                this.ListaDeAlumnos[i] = new Alumno();
            }

            foreach (Alumno objAlumno in this.ListaDeAlumnos)
            {
                objAlumno.Nombre = "N/N";
            }
            */


        }

        public static void MostrarAlumnos(Aula aulaRecorrida)
        {
            // 
            foreach (Alumno alumnoRecorrido in aulaRecorrida.ListaDeAlumnos)
            {
                if((object)alumnoRecorrido != null)
                    Console.WriteLine("Nombre: " + alumnoRecorrido.Nombre);
            }
        }

        /// <summary>
        /// Devuelve el índice del primer elemento NULL, de lo contrario retorna -1.
        /// </summary>
        /// <returns>Índice del primer elemento NULL o -1 si no hay ninguno.</returns>
        public int ObtenerIndice()
        {
            for (int i = 0; i < this.ListaDeAlumnos.Length; i++)
            {
                // Tira error cuando lo comparo con null
                if ((object)this.ListaDeAlumnos[i] == null)
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// Devuelve el índice del objeto, de lo contrario retorna -1.
        /// </summary>
        /// <param name="objAlumno">Objeto a buscar.</param>
        /// <returns>Índice del objeto o -1 si no lo encuentra.</returns>
        public int ObtenerIndice(Alumno objAlumno)
        {
            for (int i = 0; i < this.ListaDeAlumnos.Length; i++)
            {
                if ((object)this.ListaDeAlumnos[i] != null)
                    if(this.ListaDeAlumnos[i] == objAlumno)
                        return i;
            }

            return -1;
        }

        public void AgregarAlumno(Alumno objAlumno)
        {
            int indice = this.ObtenerIndice();
             if ((this.ObtenerIndice(objAlumno) == -1) && (indice != -1))
                this.ListaDeAlumnos[indice] = objAlumno;
            /*
            else
                Console.WriteLine("No se cargó el alumno.");
             */
        }

        public void BorrarAlumno(Alumno objAlumno)
        {
            for (int i = 0; i < this.ListaDeAlumnos.Length; i++)
            {
                if ((object)this.ListaDeAlumnos[i] != null)
                {
                    if (this.ListaDeAlumnos[i] == objAlumno)
                    {
                        this.ListaDeAlumnos[i] = null;
                        break;
                    }
                }
            }
        }

        public bool ExisteAlumno(Alumno objAlumno)
        {
            for (int i = 0; i < this.ListaDeAlumnos.Length; i++)
            {
                if ((object)this.ListaDeAlumnos[i] != null)
                {
                    if (this.ListaDeAlumnos[i] == objAlumno)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator ==(Aula auxAula, Alumno auxAlumno)
        {
            if (auxAula.ExisteAlumno(auxAlumno))
                return true;
            return false;
        }

        public static bool operator !=(Aula auxAula, Alumno auxAlumno)
        {
            return !(auxAula == auxAlumno);
        }

        public static Aula operator +(Aula auxAula, Alumno auxAlumno)
        {
            auxAula.AgregarAlumno(auxAlumno);
            return auxAula;
        }

        public static Aula operator -(Aula auxAula, Alumno auxAlumno)
        {
            auxAula.BorrarAlumno(auxAlumno);
            return auxAula;
        }
    }
}
