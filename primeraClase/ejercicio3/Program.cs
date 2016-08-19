using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main()
        {
            // le asigno memoria dinamica a "alguien". Instancia.
            Alumno alguien = new Alumno();
            Alumno otro = new Alumno();
            alguien.Nombre = "Agus";
            alguien.Nota = 4;

            otro.Nombre = "Mauro";
            otro.Nota = 8;

            Console.Write(Calculadora.Dividir(0, 0) + " " + alguien.Nombre + " " + alguien.Nota);
            alguien.MostrarDatos();

            if (Alumno.CompararAlumnos(alguien, otro))
                Console.WriteLine("IGUALES");
            else
                Console.WriteLine("DISTINTOS");

            if (alguien.Compararme(otro))
                Console.WriteLine("IGUALES");
            else
                Console.WriteLine("DISTINTOS");

            Console.ReadKey();
            
        }
    }
}
