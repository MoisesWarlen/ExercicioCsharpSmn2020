using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_6._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conta conta01= new Conta();
            conta01.deposita(1000);
            conta01.saca(10);        
            conta01.ColocaNumero(001);
            Cliente cliente01 = new Cliente();
            cliente01.nome = "Moises";
            conta01.Titular = cliente01;
            MessageBox.Show(""+conta01.Titular.nome);

        }
    }
}
