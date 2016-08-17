using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_03
{
    class Program
    {
        static void Main()
        {
            int numero;
            int contador;

            Console.Write("\nIngrese el número máximo hasta el que se buscará primos: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\nLista de primos: ");
            for(contador = 1; contador <= numero; contador++)
            {
                if(Program.EsPrimo(contador))
                {
                    Console.WriteLine(contador);
                }
                    
            }

            Console.ReadKey();
        }

        public static bool EsPrimo(int numero)
        {
            int contador;
            int contadorPrimo = 0;
            bool primo = false;

            for (contador = 1; contador < numero; contador++)
            {
                if ((numero % contador) == 0)
                {
                    contadorPrimo++;
                }
            }

            if (contadorPrimo < 2)
                primo = true;

            return primo;

        }
    }
}
