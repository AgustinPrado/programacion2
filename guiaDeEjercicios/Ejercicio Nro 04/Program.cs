using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_04
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 04";
            int contador;
            int numero = 1;
            int acumulador = 0;
            int cantidad = 0;

            Console.WriteLine("Los primeros 4 números perfectos son: ");
            while(cantidad < 4)
            {
                for (contador = 1; contador < numero; contador++)
                {
                    if ((numero % contador) == 0)
                        acumulador += contador;
                }
                if (numero == acumulador)
                {
                    Console.WriteLine(numero);
                    cantidad++;
                }
                acumulador = 0;
                numero++;
            }
            Console.ReadKey();
        }
    }
}
