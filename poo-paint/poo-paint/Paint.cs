using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    class Paint
    {
        public static void Main(string[] args) {
            AreaDeDesenho d = new AreaDeDesenho();
            //d.AdicionarFigura(new Retangulo(45, 67, 56, 90));
            //d.AdicionarFigura(new Retangulo(45, 67, 56, 10));
            Application.Run(d);

        }

    }
}
