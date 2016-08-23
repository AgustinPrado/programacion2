using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main()
        {
            EFabricante fabricante;
            fabricante = EFabricante.Honda;
            
            Console.WriteLine(fabricante);
            
            fabricante = (EFabricante)1;
            Console.WriteLine(fabricante);

            Carrera carrera = new Carrera();

            Auto nuevoAuto1 = new Auto();
            Auto nuevoAuto2 = new Auto();
            Auto nuevoAuto3 = new Auto();
            Auto nuevoAuto4 = new Auto();

            Console.WriteLine("{0} {1} {2} {3}",
                nuevoAuto1.Fabricante,
                nuevoAuto2.Fabricante,
                nuevoAuto3.Fabricante,
                nuevoAuto4.Fabricante);

            carrera.MostrarCarrera();

            Console.ReadKey();
        }
    }
}
