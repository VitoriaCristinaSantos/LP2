using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos_1205_2
{
    public partial class frmExercício4 : Form
    {
        public frmExercício4()
        {
            InitializeComponent();
        }

        private void btnNumericos_Click(object sender, EventArgs e)
        {
            // dias melhores 123

            int contador = 0;

            for (var x = 0; x < rchtxtTexto.Text.Length; x++)
            {
                if (Char.IsNumber(rchtxtTexto.Text[x]))
                    contador += 1; // contador = contador + 1
            }

            MessageBox.Show("Caracteres numéricos: " + contador);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;

            //hoje tem sol
            //4 - desenvolvedor 5 - usuario

            while (x < rchtxtTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro caracter branco: " + (x + 1));
                    break;
                }
                x += 1;
            }
        }

        private void btnAlfabeticos_Click(object sender, EventArgs e)
        {
            //vejo flores em você

            int contador = 0;

            foreach (char c in rchtxtTexto.Text) //criei a variável c tipo char dentro do foreach
            {
                if (Char.IsLetter(c))
                    contador += 1;
            }

            MessageBox.Show("Caracteres alfabéticos: " + contador);

        }
    }
}
