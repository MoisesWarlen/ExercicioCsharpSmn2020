using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Cliente
    {

        public string nome { get; set; }
        public Cliente(string Nome = null)
        {

            this.nome = Nome;
        }

    }
}
