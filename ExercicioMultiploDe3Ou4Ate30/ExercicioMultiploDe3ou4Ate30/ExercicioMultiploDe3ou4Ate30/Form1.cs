using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioMultiploDe3ou4Ate30
{
    public partial class ExercicioMultiploDe3E4 : Form
    {
        int qtdMult, cont;
        public ExercicioMultiploDe3E4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            qtdMult = 0;
            for (int i = 1; i <= 30; i++)
            {
                if ((i % 3 == 0)||(i % 4 == 0))
                {
                    qtdMult++;
                }
            }
            int[] vet = new int[qtdMult];
            cont = 0;
            for (int i = 1; i <= 30; i++)
            {
                if ((i % 3 == 0) || (i % 4 == 0))
                    {
                    vet[cont] = i;
                    cont++;
                }
            }
            for (int i = 0; i < cont; i++)
            {

                MessageBox.Show("numero multiplos de 3 e 4 = " +vet[i].ToString());
            }
        }
    }
}
