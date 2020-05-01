using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    { 
        int n1=1, n2=0 ,soma =0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <=100; i++)
            {

                soma = n1 + n2;
                n2 = n1;
                n1 = soma;
                if ((soma>0)&&(soma <= 100)) {
                    MessageBox.Show("Fibonacci de =>" + i + " é = " + soma);

                }
            }
            
            

        }
    }
}
