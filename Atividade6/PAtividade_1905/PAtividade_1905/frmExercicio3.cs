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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text;
            string inversa = "";

            string fraseM = frase.ToUpper();
            string fraseF = fraseM.Replace(" ", "");

            char[] arr = fraseF.ToCharArray();
            Array.Reverse(arr);
            foreach (char c in arr)
            {
                inversa = inversa + c.ToString();
            }

            txtInversa.Text = inversa;
            
            if (fraseF == inversa)
            {
                txtAfirmacao.Text = "Sim!";
            }
            else
            {
                txtAfirmacao.Text = "Não!";
            }
        }
    }
}
