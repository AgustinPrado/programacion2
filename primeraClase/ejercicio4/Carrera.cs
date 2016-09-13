﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    public class Carrera
    {
        private string _nombre;
        private string _fecha;
        private string _lugar;

        #region DEPRECATED por colección
        /*
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
         */
        #endregion
        public List<Auto> ListaDeAutos; // como si fuera un array. Colección.
        private static Random random;

        #region CONSTRUCTORES
        public Carrera()
        {
            #region DEPRECATED por colección
            /*
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
             */
            #endregion
            this.ListaDeAutos = new List<Auto>();
        }

        public Carrera(string Nombre, string Fecha, string Lugar):this()
        {
            this._nombre = Nombre;
            this._fecha = Fecha;
            this._lugar = Lugar;
        }

        static Carrera()
        {
            Carrera.random = new Random();
        }
        #endregion

        // Consigna
        // ingresar un tiempo en minutos y por cada minuto va a ser una vuelta en un for. Por cada vuelta, los autos tienen
        // que aumentar una cierta cantidad de km random. Cuando termina, hay que ver cual recorrio mas km
        // de 10 a 100. Que dsp muestre el que menos recorrio y el que mas recorrio

        #region DEPRECATED: POR SOBRECARGA
        /*
         * DEPRECATED: POR SOBRECARGA
        public void PorTiempo(int minutos)
        {
            int contadorMinutos;
            Auto mayor;
            Auto menor;
            Kilometro kilometroAux;

            for (contadorMinutos = 0; contadorMinutos < minutos; contadorMinutos++)
            {
                kilometroAux = new Kilometro(random.Next(10, 100));
                this.auto1.Agregar(kilometroAux);
                this.auto2.Agregar(new Kilometro(random.Next(10, 100)));
                this.auto3.Agregar(new Kilometro(random.Next(10, 100)));
                this.auto4.Agregar(new Kilometro(random.Next(10, 100)));
                this.auto5.Agregar(new Kilometro(random.Next(10, 100)));
                this.auto6.Agregar(new Kilometro(random.Next(10, 100)));
            }
            menor = mayor = auto1;
            if (this.auto2.ObtenerKilometros().Cantidad < menor.ObtenerKilometros().Cantidad)
                menor = auto2;
            if (this.auto2.ObtenerKilometros().Cantidad > mayor.ObtenerKilometros().Cantidad)
                mayor = auto2;
            if (this.auto3.ObtenerKilometros().Cantidad < menor.ObtenerKilometros().Cantidad)
                menor = auto3;
            if (this.auto3.ObtenerKilometros().Cantidad > mayor.ObtenerKilometros().Cantidad)
                mayor = auto3;
            if (this.auto4.ObtenerKilometros().Cantidad < menor.ObtenerKilometros().Cantidad)
                menor = auto4;
            if (this.auto4.ObtenerKilometros().Cantidad > mayor.ObtenerKilometros().Cantidad)
                mayor = auto4;
            if (this.auto5.ObtenerKilometros().Cantidad < menor.ObtenerKilometros().Cantidad)
                menor = auto5;
            if (this.auto5.ObtenerKilometros().Cantidad > mayor.ObtenerKilometros().Cantidad)
                mayor = auto5;
            if (this.auto6.ObtenerKilometros().Cantidad < menor.ObtenerKilometros().Cantidad)
                menor = auto6;
            if (this.auto6.ObtenerKilometros().Cantidad > mayor.ObtenerKilometros().Cantidad)
                mayor = auto6;

            Console.WriteLine("El que más recorrió fue un {0} y la distancia fue {1}", mayor.Fabricante, mayor.ObtenerKilometros());
            Console.WriteLine("El que menos recorrió fue un {0} y la distancia fue {1}", menor.Fabricante, menor.ObtenerKilometros());
            
            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();
        }
         */
        #endregion

        #region CorrerCarrera
        public string CorrerCarrera(Tiempo tiempo)
        {
            int contadorMinutos;
            Auto mayor;
            Auto menor;

            for (contadorMinutos = 0; contadorMinutos <  (int)tiempo; contadorMinutos++)
            {
                #region DEPRECATED por colección
                /*
                this.auto1.Agregar((Kilometro)random.Next(10, 100));
                this.auto2.Agregar((Kilometro)random.Next(10, 100));
                this.auto3.Agregar((Kilometro)random.Next(10, 100));
                this.auto4.Agregar((Kilometro)random.Next(10, 100));
                this.auto5.Agregar((Kilometro)random.Next(10, 100));
                this.auto6.Agregar((Kilometro)random.Next(10, 100));
                 */
                #endregion
                foreach (Auto objAuto in this.ListaDeAutos)
                {
                    objAuto.Agregar((Kilometro)random.Next(10, 100));
                }
            }
            menor = mayor = ListaDeAutos.First();
            #region DEPRECATED por colección
            /*
            if ((int)this.auto2.ObtenerKilometros() < (int)menor.ObtenerKilometros())
                menor = auto2;
            if ((int)this.auto2.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto2;
            if ((int)this.auto3.ObtenerKilometros() < (int)menor.ObtenerKilometros())
                menor = auto3;
            if ((int)this.auto3.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto3;
            if ((int)this.auto4.ObtenerKilometros() < (int)menor.ObtenerKilometros())
                menor = auto4;
            if ((int)this.auto4.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto4;
            if ((int)this.auto5.ObtenerKilometros() < (int)menor.ObtenerKilometros())
                menor = auto5;
            if ((int)this.auto5.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto5;
            if ((int)this.auto6.ObtenerKilometros() < (int)menor.ObtenerKilometros())
                menor = auto6;
            if ((int)this.auto6.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto6;
             */
            #endregion

            foreach (Auto objAuto in this.ListaDeAutos)
            {
                if ((int)objAuto.ObtenerKilometros() < (int)menor.ObtenerKilometros())
                    menor = objAuto;
                if ((int)objAuto.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                    mayor = objAuto;
            }

            //this.MostrarCarrera();

            /*
            Console.WriteLine("El que más recorrió fue un {0} y la distancia fue {1}", mayor.Fabricante, (int)mayor.ObtenerKilometros());
            Console.WriteLine("El que menos recorrió fue un {0} y la distancia fue {1}", menor.Fabricante, (int)menor.ObtenerKilometros());
            */
            

            #region DEPRECATED por colección
            /*
            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();
             */
            #endregion
            foreach (Auto objAuto in this.ListaDeAutos)
            {
                objAuto.VolverACero();
            }

            return mayor.DatosEnString;
        }

        public string CorrerCarrera(Kilometro kilometro)
        {
            int contadorKilometros;
            Auto mayor;
            Auto menor;
            for (contadorKilometros = 0; contadorKilometros < (int)kilometro; contadorKilometros++)
            {
                #region DEPRECATED por colección
                /*
                this.auto1.Agregar((Tiempo)random.Next(10, 100));
                this.auto2.Agregar((Tiempo)random.Next(10, 100));
                this.auto3.Agregar((Tiempo)random.Next(10, 100));
                this.auto4.Agregar((Tiempo)random.Next(10, 100));
                this.auto5.Agregar((Tiempo)random.Next(10, 100));
                this.auto6.Agregar((Tiempo)random.Next(10, 100));
                 */
                #endregion
                
                foreach (Auto objAuto in this.ListaDeAutos)
                {
                    objAuto.Agregar((Tiempo)random.Next(10, 100));
                }
                 
                /*
                for (int i = 0; i < this.ListaDeAutos.Count; i++)
                {
                    this.ListaDeAutos[i].Agregar((Tiempo)random.Next(10, 100));
                }
                 * */
            }
            menor = mayor = ListaDeAutos.First();
            #region DEPRECATED por colección
            /*
            if ((int)this.auto2.ObtenerTiempo() < (int)menor.ObtenerTiempo())
                menor = auto2;
            if ((int)this.auto2.ObtenerTiempo() > (int)mayor.ObtenerTiempo())
                mayor = auto2;
            if ((int)this.auto3.ObtenerTiempo() < (int)menor.ObtenerTiempo())
                menor = auto3;
            if ((int)this.auto3.ObtenerTiempo() > (int)mayor.ObtenerTiempo())
                mayor = auto3;
            if ((int)this.auto4.ObtenerTiempo() < (int)menor.ObtenerTiempo())
                menor = auto4;
            if ((int)this.auto4.ObtenerTiempo() > (int)mayor.ObtenerTiempo())
                mayor = auto4;
            if ((int)this.auto5.ObtenerTiempo() < (int)menor.ObtenerTiempo())
                menor = auto5;
            if ((int)this.auto5.ObtenerTiempo() > (int)mayor.ObtenerTiempo())
                mayor = auto5;
            if ((int)this.auto6.ObtenerTiempo() < (int)menor.ObtenerTiempo())
                menor = auto6;
            if ((int)this.auto6.ObtenerTiempo() > (int)mayor.ObtenerTiempo())
                mayor = auto6;
              */
            #endregion

            foreach (Auto objAuto in this.ListaDeAutos)
            {
                if ((int)objAuto.ObtenerTiempo() < (int)menor.ObtenerTiempo())
                    menor = objAuto;
                if ((int)objAuto.ObtenerTiempo() > (int)mayor.ObtenerTiempo())
                    mayor = objAuto;
            }

            //this.MostrarCarrera();

            /*
            Console.WriteLine("El que más tardó fue un {0} y el tiempo fue {1}", mayor.Fabricante, (int)mayor.ObtenerTiempo());
            Console.WriteLine("El que menos tardó fue un {0} y el tiempo fue {1}", menor.Fabricante, (int)menor.ObtenerTiempo());
            */
            

            #region DEPRECATED por colección
            /*
            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();
             */
            #endregion
            foreach (Auto objAuto in this.ListaDeAutos)
            {
                objAuto.VolverACero();
            }

            return mayor.DatosEnString;
        }
        #endregion

        public void MostrarCarrera()
        {
            #region DEPRECATED por colección
            /*
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();
             */
            #endregion

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Detalle de la carrera");

            foreach (Auto objAuto in this.ListaDeAutos)
            {
                sb.AppendLine(objAuto.MostrarAuto());
            }
            Console.Write(sb.ToString());
        }

        private void AgregarAuto(Auto auto)
        {
            this.ListaDeAutos.Add(auto);
        }

        public static Carrera operator +(Carrera carrera, Auto auto)
        {
            carrera.AgregarAuto(auto);
            return carrera;
        }
    }        
}
