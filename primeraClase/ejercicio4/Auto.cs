using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    public class Auto
    {
        // composicion: tiene otras clases dentro, como Rueda.
        public EFabricante Fabricante;
        public Rueda DI;
        public Rueda DD;
        public Rueda TI;
        public Rueda TD;
        private int KilometrosRecorridos;
        private int TiempoDemorado;
        public static int contadorDeObjetos;
        private static Random randomMarcas; // es unico para esta clase.

        public Auto()
        {
            this.Fabricante = (EFabricante)(Auto.randomMarcas.Next(0, 3));
            this.DI = new Rueda();
            this.DD = new Rueda();
            this.TI = new Rueda();
            this.TD = new Rueda();

            Auto.contadorDeObjetos++;
        }
        
        // un constructor estatico no puede ser public. Se ejecuta en la primer llamada a la clase que haga
        // tiene que tener atributos estaticos
        // puedo hacerlo para inicializar variables estaticas, como contador de objetos creados
        // no se lo puede sobrecargar
        static Auto()
        {
            Auto.contadorDeObjetos = 0;
            Auto.randomMarcas = new Random();
        }

        public static bool CompararAuto(Auto auto1, Auto auto2)
        {
            if (auto1.Fabricante == auto2.Fabricante)
                return true;
            return false;
        }

        public void MostrarAuto()
        {
            Console.WriteLine("El fabricante es {0}", this.Fabricante);
        }

        public void VolverACero()
        {
            this.KilometrosRecorridos = 0;
            this.TiempoDemorado = 0;
        }

        public void AgregarKilometro(int kilometros)
        {
            this.KilometrosRecorridos += kilometros;
        }

        public void AgregarTiempo(int tiempo)
        {
            this.TiempoDemorado += tiempo;
        }

        public int ObtenerKilometros()
        {
            return this.KilometrosRecorridos;
        }

        public int ObtenerTiempo()
        {
            return this.TiempoDemorado;
        }
    }
}
