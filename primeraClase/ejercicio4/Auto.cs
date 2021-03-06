﻿using System;
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
        
        // public Dictionary<string, Rueda> Rueda; AVERIGUAR COMO SE HACE ESTO

        private string _nombrePiloto;
        public string NombrePiloto // Propiedad. Sirve para ponerle logica.
        {
            set
            {
                this._nombrePiloto = value;
            }
            get
            {
                return this._nombrePiloto;
            }
        }

        public string DatosEnStringListado
        {
            get
            {
                return this.RetornarStringParaListado();
            }
        }

        /*
        public string DatosEnStringResultado
        {
            get
            {
                return this.RetornarStringParaResultado();
            }
        }
         * */

        private Kilometro KilometrosRecorridos;
        private Tiempo TiempoDemorado;
        public static int contadorDeObjetos;
        private static Random randomMarcas; // es unico para esta clase.
        
        // un constructor estatico no puede ser public. Se ejecuta en la primer llamada a la clase que haga
        // tiene que tener atributos estaticos
        // puedo hacerlo para inicializar variables estaticas, como contador de objetos creados
        // no se lo puede sobrecargar
        #region CONSTRUCTORES
        static Auto()
        {
            Auto.contadorDeObjetos = 0;
            Auto.randomMarcas = new Random();
        }

        public Auto()
        {
            this.Fabricante = (EFabricante)(Auto.randomMarcas.Next(0, 3));
            this.DI = new Rueda();
            this.DD = new Rueda();
            this.TI = new Rueda();
            this.TD = new Rueda();
            this.KilometrosRecorridos = 0;
            this.TiempoDemorado = 0;

            Auto.contadorDeObjetos++;
        }

        public Auto(string nombrePiloto, EFabricante fabricante):this()
        {
            this._nombrePiloto = nombrePiloto;
            this.Fabricante = fabricante;
        }
        #endregion

        public static bool CompararAuto(Auto auto1, Auto auto2)
        {
            if (auto1.Fabricante == auto2.Fabricante)
                return true;
            return false;
        }

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fabricante: " + this.Fabricante);
            sb.AppendLine("Kilometros: " + ((int)this.ObtenerKilometros()).ToString());
            sb.AppendLine("Tiempo: " + ((int)this.ObtenerTiempo()).ToString());
            //Console.WriteLine("El fabricante es {0}", this.Fabricante);
            return sb.ToString();
        }

        public void VolverACero()
        {
            this.KilometrosRecorridos = 0;
            this.TiempoDemorado = 0;
        }

        #region DEPRECATED: POR SOBRECARGA DE METODOS
        /*
         * DEPRECATED: POR SOBRECARGA DE METODOS
        public void AgregarKilometro(int kilometros)
        {
            this.KilometrosRecorridos += kilometros;
        }

        public void AgregarTiempo(int tiempo)
        {
            this.TiempoDemorado += tiempo;
        }
        */
        #endregion

        public Kilometro ObtenerKilometros()
        {
            return this.KilometrosRecorridos;
        }

        public Tiempo ObtenerTiempo()
        {
            return this.TiempoDemorado;
        }

        public void Agregar(Tiempo tiempo)
        {
            this.TiempoDemorado = this.TiempoDemorado + tiempo;
        }

        public void Agregar(Kilometro kilometro)
        {
            this.KilometrosRecorridos = this.KilometrosRecorridos + kilometro;
        }

        private string RetornarStringParaListado()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("P: " + this.NombrePiloto + " - F: " + this.Fabricante);
            return sb.ToString();
        }

        /*
        private string RetornarStringParaResultado()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("P: " + this.NombrePiloto + " - Km Recorridos: " + (int)this.ObtenerKilometros() + "km");
            return sb.ToString();
        }

        private string RetornarStringParaResultado()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("P: " + this.NombrePiloto + " - Tiempo total: " + (int)this.ObtenerTiempo() + "min");
            return sb.ToString();
        }
         * */

        public static int OrdenarPorFabricanteAsc(Auto auto1, Auto auto2)
        {
            return String.Compare(auto1.Fabricante.ToString(), auto2.Fabricante.ToString());
        }

        public static int OrdenarPorFabricanteDesc(Auto auto1, Auto auto2)
        {
            return String.Compare(auto2.Fabricante.ToString(), auto1.Fabricante.ToString());
        }

        public static int OrdenarPorPilotoAsc(Auto auto1, Auto auto2)
        {
            return String.Compare(auto1._nombrePiloto, auto2._nombrePiloto);
        }

        public static int OrdenarPorPilotoDesc(Auto auto1, Auto auto2)
        {
            return String.Compare(auto2._nombrePiloto, auto1._nombrePiloto);
        }
    }
}
