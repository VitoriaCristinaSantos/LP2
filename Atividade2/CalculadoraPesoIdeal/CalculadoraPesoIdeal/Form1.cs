using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPesoAtual.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, pAtual, pIdeal;
            if (double.TryParse(txtAltura.Text, out altura) && double.TryParse(txtPesoAtual.Text, out pAtual))
            {
                if (rbuttonMasculino.Checked == true)
                {
                    pIdeal = (72.7 * altura) - 58;
                }
                else
                {
                    pIdeal = (62.1 * altura) - 44.7;
                }

                pIdeal = Math.Round(pIdeal, 2);

                if (pAtual == pIdeal)
                    MessageBox.Show("Você está com o peso ideal!");
                else if (pAtual > pIdeal)
                    MessageBox.Show("Regime obrigatório já!");
                else 
                    MessageBox.Show("Pode comer bastante!");

            }
        }  
    }
}
