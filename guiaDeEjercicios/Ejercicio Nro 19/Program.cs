using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_Nro_19
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 19";

            BoligrafoNamespace.Boligrafo boligrafoAzul = new BoligrafoNamespace.Boligrafo(ConsoleColor.Blue, 100);
            BoligrafoNamespace.Boligrafo boligrafoRojo = new BoligrafoNamespace.Boligrafo(ConsoleColor.Red, 50);

            Console.Write("Escribir con bolígrafo rojo: ");
            if (boligrafoRojo.Pintar(int.Parse(Console.ReadLine())))
                Console.WriteLine("Alcanzó la tinta.");
            else
                Console.WriteLine("NO alcanzó la tinta.");

            boligrafoRojo.Recargar();

            Console.ReadKey();
        }
    }
}
