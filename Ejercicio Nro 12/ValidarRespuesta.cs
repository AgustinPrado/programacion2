using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N()
        {
            char letra;
            Console.Write("¿Continua ? (S / N): ");
            letra = char.Parse(Console.ReadLine());

            letra = Char.ToUpper(letra);

            if (letra == 'S')
                return true;
            else
            {
                if (letra == 'N')
                    return false;
                else
                {
                    Console.WriteLine("Por favor, ingrese una letra correcta.");
                    return ValidarRespuesta.ValidaS_N();
                }
            }
        }
    }
}
