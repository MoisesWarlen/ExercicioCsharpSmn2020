using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_soma_de_1_ate_1000
{
    public partial class somaDe1Ate1000 : Form
    {
        int total;
        public somaDe1Ate1000()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i =0 ;i <=1000 ;i ++)
            {
                total = total + i;
             
            }
            lblSoma.Text = total.ToString();
        }
    }
}
