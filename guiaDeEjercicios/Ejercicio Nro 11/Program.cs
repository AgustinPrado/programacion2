using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_11
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 11";

            int contador;
            int acumulador = 0;
            int minimo = 0;
            int maximo = 0;
            int numero;

            for(contador = 0; contador < 10; contador++)
            {
                Console.Write("Ingrese número {0}/10: ", (contador+1));
                numero = int.Parse(Console.ReadLine());
                while(!Validacion.Validar(numero, -100,100))
                {
                    Console.WriteLine("Por favor ingrese un número entre -100 y 100");
                    Console.Write("Ingrese número {0}/10: ", (contador + 1));
                    numero = int.Parse(Console.ReadLine());
                }

                if(contador == 0)
                    minimo = maximo = numero;
                else
                {
                    if (numero < minimo)
                        minimo = numero;
                    if (numero > maximo)
                        maximo = numero;
                }

                acumulador += numero;
            }

            Console.Write("Valor minimo: {0}  Valor maximo: {1}  Valor promedio: {2:0.00}", minimo, maximo, (Convert.ToSingle(acumulador) / 10));

            Console.ReadKey();
        }
    }
}
