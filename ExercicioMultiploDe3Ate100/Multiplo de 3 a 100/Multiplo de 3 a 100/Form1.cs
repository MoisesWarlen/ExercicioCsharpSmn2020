using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplo_de_3_a_100
{
    public partial class Form1 : Form
    {
        int multiplosDeTres, cont,a ,b,qtdMult;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qtdMult = 0;
           for (int i =1;i <=100;i++)
            {
                if(i % 3 == 0)
                {
                    qtdMult++;
                }
            }
            int[] vet = new int[qtdMult];
            cont = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    vet[cont] = i;
                    cont++;
                }
            }
            for (int i = 0; i <cont;i++)
            {

                lblVet.Text = ($"vet[{i}] = {vet[i]}");
                MessageBox.Show(vet[i].ToString());
            }
           
        }
    }
}
