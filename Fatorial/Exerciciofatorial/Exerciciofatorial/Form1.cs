using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerciciofatorial
{
    public partial class Form1 : Form
    {
        int fatorial = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int n =1 ;n <=10 ;n++)
            {
                fatorial *= n;
                MessageBox.Show(""+n+"fatorial ="+fatorial);

            }
        }
    }
}
