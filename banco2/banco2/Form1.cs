using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace banco2
{
    public partial class Form1 : Form
    {
        private Conta[] contas;
        private int numeroDeContas;
        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("titular: " + conta.titular.nome);
            comboDestinoTransferencia.Items.Add("titular: " + conta.titular.nome);
           
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            this.contas = new Conta[10];

           
           
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {

            int indice = comboContas.SelectedIndex;
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            contas[indice].Deposita(valorOperacao);
            textoSaldo.Text = contas[indice].Saldo.ToString();
            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Soma(contas[indice]);
            MessageBox.Show(""+ t.ValorTotal);
        }
       private void botaoSaque_Click(object sender, EventArgs e)
        {

            int indice = comboContas.SelectedIndex;
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.contas[indice].Saca (valorOperacao);
            textoSaldo.Text = contas[indice].Saldo.ToString();
            MessageBox.Show("Sucesso");
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
           int indice = 0;
            // int indice = Convert.ToInt32(textoIndice.Text);
            Conta selecionada = this.contas[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.titular.nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
       }
       private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.titular.nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = comboDestinoTransferencia.SelectedIndex;
            Conta selecionadaTransferencia = this.contas[indice];
            return;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void botaoTransferencia_Click(object sender, EventArgs e)
        {
            int indiceOrigem = comboContas.SelectedIndex;
            Conta origem = this.contas[indiceOrigem];


            int indiceDestino = comboDestinoTransferencia.SelectedIndex;
            Conta destino = this.contas[indiceDestino];


            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);


            origem.Tranfere(valorOperacao , destino );
            textoSaldo.Text = origem.Saldo.ToString();

            MessageBox.Show("Transferencia efetuada com sucesso!!");
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();

        }
    }


}
