using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; internal set; }
        public double Saldo { get; private  set; }
        internal Cliente Titular { get; set; }

        public Conta()
        {

        }
        public void Deposita(double valorOperacao)
        {
             
            this.Saldo += valorOperacao;
        }

      public void Saca(double valorOperacao)
        {
            this.Saldo -= valorOperacao;
        }
    }
}