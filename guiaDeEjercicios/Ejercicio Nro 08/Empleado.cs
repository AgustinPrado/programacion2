using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_08
{
    public class Empleado
    {
        public double ValorHora;
        public string Nombre;
        public int Antiguedad;
        public int HorasTrabajadas;

        public double CalcularSueldoBruto()
        {
            return ((this.ValorHora * Convert.ToDouble(this.HorasTrabajadas)) + (Convert.ToDouble(this.Antiguedad) * 150));
        }

        public double CalcularDescuentos()
        {
            return (this.CalcularSueldoBruto() * 0.13); 
        }

        public double CalcularSueldoNeto()
        {
            return (this.CalcularSueldoBruto() - this.CalcularDescuentos());
        }
    }
}
