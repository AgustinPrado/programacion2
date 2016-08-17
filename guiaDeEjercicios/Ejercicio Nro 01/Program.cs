using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_01
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 01";
            float numero;
            float maximo = 0;
            float minimo = 0;
            float acumulador = 0;
            int contador;

            for (contador = 0; contador < 5; contador++)
            {
                Console.Write("\nIngrese un numero: ");
                numero = float.Parse(Console.ReadLine());
                if (contador == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    else
                    {
                        if (numero < minimo)
                        {
                            minimo = numero;
                        }
                    }
                }
                acumulador += numero;
            }

            Console.Write("\nValor mínimo: " + minimo);
            Console.Write("\nValor máximo: " + maximo);
            Console.Write("\nPromedio: " + (acumulador/5) );
            Console.ReadKey();

        }
    }
}
