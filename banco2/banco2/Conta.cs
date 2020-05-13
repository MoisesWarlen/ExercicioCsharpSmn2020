using System;

namespace banco2
{
    public class Conta
    {
        public int Numero { get; internal set; }
        public double Saldo { get; protected set; }
        public Cliente titular { get; internal set; }
        public Conta()
        {
            this.Saldo = 100;
        }
        public virtual void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }
        public virtual void Saca(double valorOperacao)
        {
            this.Saldo -= valorOperacao;
        }

        // metodo tranfere
        public void Tranfere(double valor , Conta contaDestino)
        {
            this.Saldo -= valor;
            contaDestino.Saldo += valor;
        }
    }

}