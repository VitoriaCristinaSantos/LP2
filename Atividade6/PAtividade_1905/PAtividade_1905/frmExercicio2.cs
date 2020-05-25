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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnGerarH_Click(object sender, EventArgs e)
        {
            int N;
            string numero = txtNumeroN.Text;
            int.TryParse(numero, out N);

            int i;
            double H = 0;

            for(i=1; i<=N; i++)
            {
                H = H + (1 /(double) i);
            }

            txtNumeroH.Text = H.ToString("N4");
            

        }
    }
}
