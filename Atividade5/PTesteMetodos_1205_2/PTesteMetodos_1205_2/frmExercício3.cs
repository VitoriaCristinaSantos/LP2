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
    public partial class frmExercício3 : Form
    {
        public frmExercício3()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int posicao = 0; //

            txtPalavra1.Text = txtPalavra1.Text.ToUpper(); //passando o conteúdo da textbox 1 para maiusculo
            txtPalavra2.Text = txtPalavra2.Text.ToUpper(); // da textbox 2 também

            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text); //procurando a palavra 1 na palavra 2 
            //e guardando em a posicao achada dentro da variavel posicao (mostra a primeira ocorrencia, entao vamos repetir)

            while (posicao >= 0) // a busca do indexof inicia em 0
            {
                //1ª parte da palavra
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) + //copiando o conteudo da txtbox2 da pos 0 até a posicao

                //2ª parte da palavra
                //copia da posicao + tamanho da palavra 1 (para desprezar a cópia do caracter que vai ser removido)

                txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length, txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text); //continua rodando enquanto tiver algo do 1 no 2
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, " ");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray(); // jogo a string para um array
            Array.Reverse(arr); // invertendo o array
            s = "";
            foreach (char c in arr)
                s = s + c.ToString();
            MessageBox.Show(s);

            //ou

            /* string ss = txtPalavra1.Text;
            char[] arr1 = ss.ToCharArray();
            Array.Reverse(arr1);
            ss = new string(arr1);
            MessageBox.Show(ss);*/
        }
    }
}
