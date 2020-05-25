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
    public partial class frmExercício2 : Form
    {
        public frmExercício2()
        {
            InitializeComponent();
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0) //retorna um inteiro, se estiverem iguais será = 0. True ignora o case sensitive
                MessageBox.Show("Palavras iguais!");
            else
                MessageBox.Show("Palavras diferentes!");
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            //x         x
            //casa      fatec   
            //ca x sa     fa x tec

            int meio = txtPalavra2.Text.Length / 2; //acha a metade da palavra2 e guarda na variavel meio inteira, então não pega os quebrados
            //pegando o caracter na posição 0 e copiando até o caracter na posição meio + concatenando com a palavra 1
            //+ pegando o caracter da posição meio até o fim (total de caracteres - meio = copiar tantos caracteres a partir do meio)
            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) + txtPalavra1.Text +
                txtPalavra2.Text.Substring(meio, txtPalavra2.Text.Length - meio); //isso vai ser inserido na textbox2

        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra1.Text.Length / 2;
            txtPalavra1.Text = txtPalavra1.Text.Insert(meio, "**"); //está inserindo dois caracteres ** depois da posição do meio
        }
    }
}
