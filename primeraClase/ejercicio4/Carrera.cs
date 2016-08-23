using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    public class Carrera
    {
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
        private static Random randomKilometros;

        public Carrera()
        {
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
            randomKilometros = new Random();
        }

        // ingresar un tiempo en minutos y por cada minuto va a ser una vuelta en un for. Por cada vuelta, los autos tienen
        // que aumentar una cierta cantidad de km random. Cuando termina, hay que ver cual recorrio mas km
        // de 10 a 100. Que dsp muestre el que menos recorrio y el que mas recorrio
        public void PorTiempo(int minutos)
        {
            int contadorVueltas;
            for (contadorVueltas = 0; contadorVueltas < minutos; contadorVueltas++)
            {
                this.auto1.AgregarKilometro(randomKilometros.Next(10, 100));
                this.auto2.AgregarKilometro(randomKilometros.Next(10, 100));
                this.auto3.AgregarKilometro(randomKilometros.Next(10, 100)); 
                this.auto4.AgregarKilometro(randomKilometros.Next(10, 100));
                this.auto5.AgregarKilometro(randomKilometros.Next(10, 100));
                this.auto6.AgregarKilometro(randomKilometros.Next(10, 100)); 
            }
                                  
        }

        public void MostrarCarrera()
        {
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();
        }
    }        
}
