using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_06
{
    public class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 06";
            int año;
            Console.Write("Ingrese el año que desea verificar si es bisiesto: ");
            año = int.Parse(Console.ReadLine());

            if(Program.EsBisiesto(año))
                Console.WriteLine("ES BISIESTO");
            else
                Console.WriteLine("NO ES BISIESTO");

            Console.ReadKey();
        }

        public static bool EsBisiesto(int año)
        {
            bool bisiesto = false;
            if((año % 4) == 0)
            {
                if ((año % 100) == 0)
                {
                    if ((año % 400) == 0)
                        bisiesto = true;
                }
                else
                    bisiesto = true;
            }
            return bisiesto;
        }
    }
}
