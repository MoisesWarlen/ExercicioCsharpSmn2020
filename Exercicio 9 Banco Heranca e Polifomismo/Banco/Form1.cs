using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta1;
        public Form1()
        {
            InitializeComponent();
        }

      private void Form1_Load(object sender, EventArgs e)
        {

          

            conta1 = new ContaCorrente();
            conta1.Numero = 1;
            Cliente cliente = new Cliente("Victor");
            conta1.Titular = cliente;

          

            

            textoTitular.Text = conta1.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta1.Numero);
            textoSaldo.Text = Convert.ToString(conta1.Saldo);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
           

            if(textoValor.Text == "")
            {
                MessageBox.Show("Favor preencher o campo");
                return;
            }
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta1.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(conta1.Saldo);
            MessageBox.Show("Sucesso");
         
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta1.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta1.Saldo);
            MessageBox.Show("Sucesso");
   

        }
    }
}
