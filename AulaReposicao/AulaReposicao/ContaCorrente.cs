using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaReposicao
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(int saldo) : base(saldo) {
            
        }

        public ContaCorrente() : this(0)
        {
            
        }

        public override string GerarExtrato() {
            return "Extrato da conta corrente:";
        }
    }
}
