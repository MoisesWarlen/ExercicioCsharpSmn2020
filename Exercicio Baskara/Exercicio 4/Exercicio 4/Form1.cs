using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_4
{
    public partial class Form1 : Form
    {
        int a, b, c;
        double delta, a1, a2 ;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            c = int.Parse(txtC.Text);
          
            if (a == 0)
            {
                MessageBox.Show("valor de a,b e c devem ser diferente de zero ");
            }
            else
            {
                delta = ((b*b) - (4 * a * c));
                if (delta == 0)
                {
                    a1 = (-b + Math.Sqrt(delta)) / (2 * a);

                    MessageBox.Show("Delta igual a Zero X1 e X2 = " +  a1);
                }
                else if (delta > 0)
                {
                    
                    a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    a2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    MessageBox.Show(" delta maior que Zero " + "\n" + "\n" + " X1 = " + a1.ToString("F") + "\n" + " X2 = " + a2.ToString("F"));

                }
                else if (delta<0)
                {
 
                    MessageBox.Show("Delta menor  Zero ! não existe valor real "  );

                }



            }

        }
    }
}
