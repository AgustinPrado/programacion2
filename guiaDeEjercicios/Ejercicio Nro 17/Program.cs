using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_17
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 17";

            Cuenta cuenta = new Cuenta();
            Console.Write("Ingrese nombre: ");
            cuenta.setNombre(Console.ReadLine());
            Console.Write("Ingrese número de cuenta: ");
            cuenta.setNroCuenta(long.Parse(Console.ReadLine()));
            Console.Write("Ingrese saldo: ");
            cuenta.setSaldo(double.Parse(Console.ReadLine()));
            Console.Write("Ingrese tipo de interés: ");
            cuenta.setTipoInteres((ETipoInteres)int.Parse(Console.ReadLine()));

            Console.WriteLine(cuenta.getNombre());
            Console.WriteLine(cuenta.getNroCuenta());
            Console.WriteLine(cuenta.getSaldo());
            Console.WriteLine(cuenta.getTipoInteres());

            Console.ReadKey();
        }
    }
}
