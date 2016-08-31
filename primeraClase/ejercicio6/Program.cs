using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main()
        {
            Dolar und;
            Pesos unp;

            und = 1;
            unp = (Pesos)1;

            und = und + unp;
            unp = unp + und;

            Console.ReadKey();
        }
    }
}

/*
 * 
*/