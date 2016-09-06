using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9_Arrays
{
    class Program
    {
        static void Main()
        {
            Aula miPrimerAula = new Aula();

            Alumno alu1 = new Alumno("Agus", 123);
            Alumno alu2 = new Alumno("Santi", 129);
            Alumno alu3 = new Alumno("Chalo", 198);
            Alumno alu4 = new Alumno("Gonza", 200);

            miPrimerAula = miPrimerAula + alu1;
            miPrimerAula = miPrimerAula + alu2;
            miPrimerAula = miPrimerAula + alu3;

            miPrimerAula = miPrimerAula - alu2;

            miPrimerAula = miPrimerAula + alu4;

            miPrimerAula = miPrimerAula + alu1;
            miPrimerAula = miPrimerAula + alu2;
            miPrimerAula = miPrimerAula + alu3;

            /*
             * DEPRECATED POR SOBRECARGA DE OPERADOR
            miPrimerAula.AgregarAlumno(alu1);
            miPrimerAula.AgregarAlumno(alu2);
            miPrimerAula.AgregarAlumno(alu3);

            miPrimerAula.BorrarAlumno(alu2);

            miPrimerAula.AgregarAlumno(alu4);

            miPrimerAula.AgregarAlumno(alu1);
            miPrimerAula.AgregarAlumno(alu2);
            miPrimerAula.AgregarAlumno(alu3);
             */

            Aula.MostrarAlumnos(miPrimerAula);

            if (miPrimerAula.ExisteAlumno(alu2))
                Console.WriteLine("EXISTE");
            else
                Console.WriteLine("NO EXISTE");

            Console.ReadKey();
        }
    }
}
