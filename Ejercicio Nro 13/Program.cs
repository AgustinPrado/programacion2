using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 13";

            Console.Write("Ingrese binario: ");
            Console.WriteLine("Equivale en decimal a: " + Conversor.BinarioDecimal(Console.ReadLine()));

            Console.Write("Ingrese decimal: ");
            Console.WriteLine("Equivale en binario a: " + Conversor.DecimalBinario(double.Parse(Console.ReadLine())));

            Console.ReadKey();
        }
    }
}
