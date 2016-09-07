using System;
using System.Collections.Generic; // generic de género, no de genérico
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main()
        {
            /*
            EFabricante fabricante;
            fabricante = EFabricante.Honda;
            
            Console.WriteLine(fabricante);
            
            fabricante = (EFabricante)1;
            Console.WriteLine(fabricante);
            */

            List<Auto> ListaAuto = new List<Auto>();

            ArrayList ArrayListaAuto = new ArrayList(); // le puedo agregar cualquier cosa. En el foreach va a pinchar si busco por algun tipo de objeto que no tiene

            ArrayListaAuto.Add("Hola");
            ArrayListaAuto.Add(15);

            Stack<Auto> PilaAuto = new Stack<Auto>();

            Auto AutoAux = PilaAuto.Pop();

            Queue<Auto> ColaAuto = new Queue<Auto>();

            AutoAux = ColaAuto.Dequeue();

            


            Rueda otraRueda = new Rueda(3);
            Rueda otraRueda2 = new Rueda("RuedaLoca");
            Rueda otraRueda3 = new Rueda("Firestone", 15);

            Carrera carrera = new Carrera();

            Auto nuevoAuto1 = new Auto();
            Auto nuevoAuto2 = new Auto();
            Auto nuevoAuto3 = new Auto();
            Auto nuevoAuto4 = new Auto();

            carrera = carrera + nuevoAuto1;
            carrera = carrera + nuevoAuto2;
            carrera = carrera + nuevoAuto3;
            carrera = carrera + nuevoAuto4;

            Tiempo tiempo = 5;
            Kilometro kilometro = 9;

            /*
            Console.WriteLine("{0} {1} {2} {3}",
                nuevoAuto1.Fabricante,
                nuevoAuto2.Fabricante,
                nuevoAuto3.Fabricante,
                nuevoAuto4.Fabricante);
             */

            // carrera.MostrarCarrera();
            // carrera.PorTiempo(5);

            carrera.CorrerCarrera(tiempo);

           
            carrera.CorrerCarrera(kilometro);

            carrera.CorrerCarrera(tiempo);

            tiempo = tiempo + 10; // funciona porque esta sobrecargado el operador

            Console.WriteLine("El tiempo es: " + (int)tiempo);

            Console.ReadKey();
        
        }
    }
}

/*
 * 30/08
 * Casteo implicito y explicito.
 * (int) casteo explicito.
 * si le pongo implicit funciona de las dos formas
 * public static implicit operator Tiempo(int numero)
 * 
 * si no se construye el objeto esta en null
 * octaviovillegas/constructores-metedos
*/