using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace poo_paint
{
    class Circulo : Figura
    {
        private int raio = 0;

        public Circulo(int x, int y, int raio)
        {
            this.x = x;
            this.y = y;
            this.raio = raio;
        }

        public override String Imprime() {
            return "circulo[x:" + this.x + ",y:" + this.y + ",r:" + this.raio + "]";
        }

    }
}
