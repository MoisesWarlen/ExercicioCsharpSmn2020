using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio
{
    public partial class Form1 : Form
    {  
        int valor;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            valor = int.Parse(txtNumero.Text);

            bool verifica = (valor > 10); MessageBox.Show("numero  digitado  e maior ? "+verifica);


        }
    }
}
