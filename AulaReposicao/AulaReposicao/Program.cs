using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaReposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new ContaCorrente(50);
            Conta c2 = new ContaCorrente(100);
            Conta c3 = new ContaCorrente(300);

            Conta.cotacaoDolar = 2.5;
            
            c2.saldo = c1.saldo + c3.saldo;
            c1 = c3;
            c3.saldo += 100;

            Console.WriteLine(c1.saldo);
            Console.WriteLine(c2.saldo);
            Console.WriteLine(c3.saldo);

            Console.WriteLine(c3.GerarExtrato());
            Console.ReadKey();
        }

        static void Main(string[] args, int x) {
        
        }
    }


}
