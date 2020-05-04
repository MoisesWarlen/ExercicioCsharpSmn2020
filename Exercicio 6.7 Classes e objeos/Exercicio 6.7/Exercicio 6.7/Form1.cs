using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_6._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conta contaVitor = new conta(); // declarando novo objeto
            contaVitor.titular = "Vitor";
            contaVitor.numero = 1;       
            contaVitor.idade=21;
            

            if (contaVitor.saca(30))  //validação para sacar
            {
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao sacar ");
            }


        }
    }
}
