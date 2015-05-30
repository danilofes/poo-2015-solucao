using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaReposicao
{
    abstract class Conta
    {
        public static double cotacaoDolar = 3.0;
        public int saldo = 0;

        public Conta(int saldo)
        {
            this.saldo = saldo;
        }

        public virtual string GerarExtrato()
        {
            return "";
        }

        public virtual string GerarExtrato(String mes)
        {
            return "";
        }
    }
}
