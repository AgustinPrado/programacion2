using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main()
        {
            Producto prod1 = (Producto)33;
            
            int resultado;

            resultado = prod1 + prod1;

            Console.WriteLine("El resultado es {0}", resultado);
            Console.ReadKey();
        }
    }
}

/*
 * Clase 31/08
 * Hacer que funcionen las siguientes lineas de codigo:
 * Producto prod1 = (Producto)33;
 * int resultado;   
 * resultado = prod1 + prod1;
 * 
 * La manera de resolverlo es:
 * Declarar un atributo int como privado.
 * Crear un constructor que reciba un entero y le asigne ese valor al atributo privado.
 * Sobrecargar el operador Producto para poder generar el casteo. Dentro, instancio al producto.
 * Sobrecargar el operador + para que sume dos productos y devuelta el valor de ambos. Sumo sus valores.
 * 
 *      private int _valor;

        public Producto(int numero)
        {
            this._valor = numero;
        }

        public static explicit operator Producto(int numero)
        {
            return new Producto(numero);
        }

        public static int operator +(Producto producto1, Producto producto2)
        {
            return producto1._valor + producto2._valor;
        }
              
*/