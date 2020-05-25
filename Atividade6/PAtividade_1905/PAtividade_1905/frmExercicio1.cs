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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnBrancos_Click(object sender, EventArgs e)
        {
            string texto = rchtxtTexto.Text;
            int brancos = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (Char.IsWhiteSpace(texto[i]))
                    brancos = brancos + 1;
            }
            MessageBox.Show("A quantidade de espaços em branco é: " + brancos);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            string textoR = rchtxtTexto.Text;
            int Rs = 0;
            
            foreach (char r in textoR)
            {
                if (r == 'R' || r == 'r')
                    Rs = Rs + 1;
            }
            MessageBox.Show("A quantidade de Rs é: " + Rs);
        }

        private void btnParDeLetras_Click(object sender, EventArgs e)
        {
            string texto = rchtxtTexto.Text;
            int pares = 0;
            int i;

            for (i=0; i < texto.Length-1; i++)
                {
                    if (texto[i] == texto[i+1])
                        pares = pares + 1;
                }
            MessageBox.Show("A quantidade de pares consecutivos é: " + pares);
        }
    }
}

