using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligrafoNamespace
{
    public class Boligrafo
    {
        private ConsoleColor _color;
        private int _tinta;

        public Boligrafo(ConsoleColor color, int tinta)
        {
            this._color = color;
            if (tinta <= 100)
                this._tinta = tinta;
            else
                this._tinta = 100;
        }

        public bool Pintar(int gasto)
        {
            if(gasto <= this.GetTinta())
            {
                this._tinta -= gasto;
                return true;
            }
            return false;            
        }

        public void Recargar()
        {
            this._tinta = 100;
        }

        public int GetTinta()
        {
            return this._tinta;
        }

        public ConsoleColor GetColor()
        {
            return this._color;
        }
    }
}
