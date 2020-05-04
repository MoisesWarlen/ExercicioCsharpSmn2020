using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6._8
{
   class Conta
    {
        private int numero;
        private double saldo;
        private Cliente titular;
        // criando metodo saca
        public bool saca(double valor)
        {
            valor += 0.10;
            if (this.saldo > valor && valor > 0)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }
        // criando o metodo deposita

        public bool deposita(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                return true;
            }
            return false;
        }

        // criando metodo transafere
        public bool transfere(Conta pessoa, double valor)
        {
            if (this.saldo>=valor && valor>0)
            {
                this.saldo -= valor;
                pessoa.saldo += valor;
                return true;
            }
            return false;
        }


        /// criando metodo pega saldo
        public double PegaSaldo()
        {
            return this.saldo;
        }
        // criando metodo ColocaNumero

        public void ColocaNumero(int num)
        {

            this.numero = num;

        }


        public int Numero
        {
            get
            {
                return this.numero;//mostra
            }
           private set
            {
                this.numero = value;//salva
            }
        }

        public double Saldo
        {
            get
            {

                return this.saldo;
            }
        
            private set
            {

                this.saldo = value;
            }

        }
        public Cliente Titular
        {

            get
            {
                return this.titular;
            }
            set
            {


                this.titular = value;
            }



        }




    }
}
