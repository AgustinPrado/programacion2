using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    public class Rueda
    {
        public string Marca;
        public float Tamanio;

        // el constructor no tiene retorno, no devuelve nada, ni siquiera void
        // tiene que tener el mismo nombre que la clase
        // es el valor que le pone por defecto
        // se ejecuta una unica vez y es cuando se crea el objeto
        public Rueda()
        {
            this.Marca = "Sin marca";
        }

        public void MostrarRueda()
        {
            Console.WriteLine("El tamaño es {0:#,###.00}", this.Tamanio);
        }
    }
}
