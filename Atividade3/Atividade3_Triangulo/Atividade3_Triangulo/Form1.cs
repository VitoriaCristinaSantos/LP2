using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3_Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double LadoA, LadoB, LadoC;
            if (double.TryParse(txtLadoA.Text, out LadoA) &&
                double.TryParse(txtLadoB.Text, out LadoB) &&
                double.TryParse(txtLadoC.Text, out LadoC))
            {

                if ((LadoA < LadoB + LadoC) && (LadoB < LadoA + LadoC) && (LadoC < LadoA + LadoB))
                {
  
                 if (LadoA != LadoB && LadoA != LadoC && LadoB != LadoC)
                     MessageBox.Show("Triangulo escaleno");
                 if (LadoA == LadoB && LadoB == LadoC)
                     MessageBox.Show("Triângulo equilátero");
                 if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
                     MessageBox.Show("Triângulo isósceles");
 
                }               
                else
                {
                    MessageBox.Show("Não é um triângulo!");
                }
            }
            else
            {
                MessageBox.Show("Por favor insira dados válidos!");
            }
        }

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}
