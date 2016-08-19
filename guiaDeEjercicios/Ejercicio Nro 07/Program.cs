using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_07
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 07";
            int año;
            int mes;
            int dia;

            Console.Write("Ingrese el año en que nacio: ");
            año = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el mes en que nacio: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el dia en que nacio: ");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Usted tiene " + Program.CalcularDiasVividos(dia, mes, año) + " dias vividos.");
            Console.ReadKey();
        }

        public static int CalcularDiasVividos(int dia, int mes, int año)
        {
            int contador;
            int acumulador = 0;

            acumulador += DateTime.DaysInMonth(año, mes) - dia;

            for(contador = (mes + 1); contador <= 12; contador++)
            {
                // ya me reconoce si es bisiesto
                acumulador += DateTime.DaysInMonth(año, contador);      
            }

            for(contador = año + 1; contador < DateTime.Now.Year; contador++)
            {
                acumulador += 365;
                if (Ejercicio_Nro_06.Program.EsBisiesto(contador))
                    acumulador++;                    
            }

            for (contador = 1; contador < DateTime.Now.Month; contador++)
            {
                // ya me reconoce si es bisiesto
                acumulador += DateTime.DaysInMonth(DateTime.Now.Year, contador);
            }

            acumulador += DateTime.Now.Day;


            return acumulador;

        }
    }
}
