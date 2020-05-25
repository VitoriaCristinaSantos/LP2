using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade_1905
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fazendo as conversões da textbox para variáveis double

            double.TryParse(txtProducao.Text, out double prod);
            double.TryParse(txtSalario.Text, out double salario);
            double.TryParse(txtGratificacao.Text, out double grat);

            //Calculando o salário bruto (vou chamar a val double de salariobruto no final)

            int B, C, D;

            if (prod >= 100)
            {
                B = 1;
            }
            else
            {
                B = 0;
            }
            if (prod >=120)
            {
                C = 1;
            }
            else
            {
                C = 0;
            }
            if (prod >= 150)
            {
                D = 1;
            }
            else
            {
                D = 0;
            }

            double salariobruto = salario + salario * ((0.05 * B) + (0.1 * C) + (0.1 * D)) + grat;

            if (salariobruto <= 7000)
            {
                txtSalarioBruto.Text = salariobruto.ToString();
            }
            else if (salariobruto > 7000 && grat > 0 && prod >=150)
            {
                txtSalarioBruto.Text = salariobruto.ToString();
            }
            else
            {
                txtSalarioBruto.Text = "7000";
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
