using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6._7
{
    class conta
    {

         public double saldo =1000;
         public int numero ,idade;
         public string titular;
        

        public void Deposita(double valor)
        {

           this. saldo += valor;

        }
        public bool saca(double valor)
        {
            if ((this.saldo >= valor) && (valor > 0))//se tiver dinheiro
            {
                if (this.idade >= 18)//se for de maior 
                {

                    this.saldo -= valor;//saca qualquer valor 
                    return true;//falo q deu certo 
                }

                else//se for menor de 18
                {
                    if (valor >= 200)//verifico se vai sacar mais de 200 R$
                    {
                        return false;//nao deixo sacar mais de 200 R$
                    }
                    this.saldo -= valor;//se for menos de 200
                    return true;//falo q deu certo 
                }
            }
            return false;//se nao tiver dinheiro
        }


        public void tranfere(double valor ,conta destino)
        {
            this.saca(valor);
            destino.Deposita(valor);
            
        }

    }


}
