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
        private static Random random;

        public Carrera()
        {
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
            
        }

        static Carrera()
        {
            Carrera.random = new Random();
        }

        // ingresar un tiempo en minutos y por cada minuto va a ser una vuelta en un for. Por cada vuelta, los autos tienen
        // que aumentar una cierta cantidad de km random. Cuando termina, hay que ver cual recorrio mas km
        // de 10 a 100. Que dsp muestre el que menos recorrio y el que mas recorrio
        public void PorTiempo(int minutos)
        {
            int contadorMinutos;
            Auto mayor;
            Auto menor;
            for (contadorMinutos = 0; contadorMinutos < minutos; contadorMinutos++)
            {
                this.auto1.AgregarKilometro(random.Next(10, 100));
                this.auto2.AgregarKilometro(random.Next(10, 100));
                this.auto3.AgregarKilometro(random.Next(10, 100)); 
                this.auto4.AgregarKilometro(random.Next(10, 100));
                this.auto5.AgregarKilometro(random.Next(10, 100));
                this.auto6.AgregarKilometro(random.Next(10, 100)); 
            }
            menor = mayor = auto1;
            if (this.auto2.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto2;
            if (this.auto2.ObtenerKilometros() > mayor.ObtenerKilometros())
                mayor = auto2;
            if (this.auto3.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto3;
            if (this.auto3.ObtenerKilometros() > mayor.ObtenerKilometros())
                mayor = auto3;
            if (this.auto4.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto4;
            if (this.auto4.ObtenerKilometros() > mayor.ObtenerKilometros())
                mayor = auto4;
            if (this.auto5.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto5;
            if (this.auto5.ObtenerKilometros() > mayor.ObtenerKilometros())
                mayor = auto5;
            if (this.auto6.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto6;
            if (this.auto6.ObtenerKilometros() > mayor.ObtenerKilometros())
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

        public void CorrerCarrera(Tiempo tiempo)
        {
            int contadorMinutos;
            Auto mayor;
            Auto menor;
            for (contadorMinutos = 0; contadorMinutos < tiempo.Cantidad; contadorMinutos++)
            {
                this.auto1.AgregarKilometro(random.Next(10, 100));
                this.auto2.AgregarKilometro(random.Next(10, 100));
                this.auto3.AgregarKilometro(random.Next(10, 100));
                this.auto4.AgregarKilometro(random.Next(10, 100));
                this.auto5.AgregarKilometro(random.Next(10, 100));
                this.auto6.AgregarKilometro(random.Next(10, 100));
            }
            menor = mayor = auto1;
            if (this.auto2.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto2;
            if (this.auto2.ObtenerKilometros() > mayor.ObtenerKilometros())
                mayor = auto2;
            if (this.auto3.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto3;
            if (this.auto3.ObtenerKilometros() > mayor.ObtenerKilometros())
                mayor = auto3;
            if (this.auto4.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto4;
            if (this.auto4.ObtenerKilometros() > mayor.ObtenerKilometros())
                mayor = auto4;
            if (this.auto5.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto5;
            if (this.auto5.ObtenerKilometros() > mayor.ObtenerKilometros())
                mayor = auto5;
            if (this.auto6.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto6;
            if (this.auto6.ObtenerKilometros() > mayor.ObtenerKilometros())
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

        public void CorrerCarrera(Kilometro kilometro)
        {
            int contadorKilometros;
            Auto mayor;
            Auto menor;
            for (contadorKilometros = 0; contadorKilometros < kilometro.Cantidad; contadorKilometros++)
            {
                this.auto1.AgregarTiempo(random.Next(10, 100));
                this.auto2.AgregarTiempo(random.Next(10, 100));
                this.auto3.AgregarTiempo(random.Next(10, 100));
                this.auto4.AgregarTiempo(random.Next(10, 100));
                this.auto5.AgregarTiempo(random.Next(10, 100));
                this.auto6.AgregarTiempo(random.Next(10, 100));
            }
            menor = mayor = auto1;
            if (this.auto2.ObtenerTiempo() < menor.ObtenerTiempo())
                menor = auto2;
            if (this.auto2.ObtenerTiempo() > mayor.ObtenerTiempo())
                mayor = auto2;
            if (this.auto3.ObtenerTiempo() < menor.ObtenerTiempo())
                menor = auto3;
            if (this.auto3.ObtenerTiempo() > mayor.ObtenerTiempo())
                mayor = auto3;
            if (this.auto4.ObtenerTiempo() < menor.ObtenerTiempo())
                menor = auto4;
            if (this.auto4.ObtenerTiempo() > mayor.ObtenerTiempo())
                mayor = auto4;
            if (this.auto5.ObtenerTiempo() < menor.ObtenerTiempo())
                menor = auto5;
            if (this.auto5.ObtenerTiempo() > mayor.ObtenerTiempo())
                mayor = auto5;
            if (this.auto6.ObtenerTiempo() < menor.ObtenerTiempo())
                menor = auto6;
            if (this.auto6.ObtenerTiempo() > mayor.ObtenerTiempo())
                mayor = auto6;

            Console.WriteLine("El que más tardó fue un {0} y el tiempo fue {1}", mayor.Fabricante, mayor.ObtenerTiempo());
            Console.WriteLine("El que menos tardó fue un {0} y el tiempo fue {1}", menor.Fabricante, menor.ObtenerTiempo());
            
            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();
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
