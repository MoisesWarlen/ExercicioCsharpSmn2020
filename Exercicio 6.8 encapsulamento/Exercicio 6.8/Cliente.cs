using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6._8
{
    class Cliente
    {
        public string nome, rg, cpf, endereco;
        public int idade;


        public bool EmaiorDeIdade(int idade)
        {

            if (idade>=18) {

                return true;
            }
            return false;
        }

       

    }

}
