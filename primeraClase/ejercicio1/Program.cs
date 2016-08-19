using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main()
        {
            int contador;
            float acumulador = 0;
            Console.Title = "Agustin Prado";
     
            for (contador = 0; contador < 5; contador++)
            {
                Console.Write("Número (" + (contador + 1) + "/5): ");
                acumulador = int.Parse(Console.ReadLine());
            }

            

            Console.Clear();
            Console.Write("El acumulado es: " + acumulador);
            Console.Write("\nEl promedio es: " + (acumulador / 5) );
            Console.ReadKey();
        }
    }
}
