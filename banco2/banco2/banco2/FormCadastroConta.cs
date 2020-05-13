using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco2
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

            private void botaoCadastro_Click(object sender, EventArgs e)
        {
            string tipo = comboTipoConta.Text;

            if(tipo == "Poupanca")
            {

                Conta novaConta = new ContaPoupanca();
                novaConta.titular = new Cliente(textoTitular.Text);
                novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }
            else
            {
                Conta novaConta = new ContaCorrente();
                novaConta.titular = new Cliente(textoTitular.Text);
                novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }

            
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            comboTipoConta.Items.Add("Poupanca");
            comboTipoConta.Items.Add("Corrente");
        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {

         
        }
    }
}
