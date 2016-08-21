using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_08
{
    class Program
    {
        static void Main()
        {
            int cantidad;
            int contador;

            Console.Title = "Ejercicio Nro 08";
            Console.Write("Ingrese la cantidad de empleados: ");
            cantidad = int.Parse(Console.ReadLine());

            Empleado[] empleado = new Empleado[cantidad];

            Console.Clear();

            for(contador = 0; contador < cantidad; contador++)
            {
                empleado[contador] = new Empleado();
                Console.Write("Ingrese el nombre del empleado " + (contador+1) + "/" + cantidad + ": ");
                empleado[contador].Nombre = Console.ReadLine();
                Console.Write("Ingrese el valor hora: ");
                empleado[contador].ValorHora = float.Parse(Console.ReadLine());
                Console.Write("Ingrese la antigüedad en años: ");
                empleado[contador].Antiguedad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la cantidad de horas trabajadas: ");
                empleado[contador].HorasTrabajadas = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("{0, -20} | {1, -4} | {2, -8} | {3, -11} | {4, -11} | {5, -11}",
                "Nombre",
                "Ant.",
                "$/H",
                "S. Bruto",
                "Desc.",
                "S. Neto");

            for (contador = 0; contador < cantidad; contador++)
            {
                Console.WriteLine("{0, -20} | {1, -4} | {2, -4:C2} | {3, -8:C2} | {4, -8:C2} | {5:C2}",
                    empleado[contador].Nombre,
                    empleado[contador].Antiguedad,
                    empleado[contador].ValorHora,
                    empleado[contador].CalcularSueldoBruto(),
                    empleado[contador].CalcularDescuentos(),
                    empleado[contador].CalcularSueldoNeto());
            }

            Console.ReadKey();

        }
    }
}
