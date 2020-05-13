using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco2
{
    public class ContaPoupanca:Conta
    {
        
        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
        }

        public ContaPoupanca(int numero)
        {
            // A propriedade Numero veio herdada da classe Conta
            this.Numero = numero;
        }

        public ContaPoupanca()
        {
        }

        public void CalculaRendimento()
        {
            // ...
        }

    }
}
