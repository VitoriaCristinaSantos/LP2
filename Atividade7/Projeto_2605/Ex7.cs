using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; 
using System.Collections;

namespace Projeto_2605
{
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int i;
            ArrayList Nomes = new ArrayList();
            string nome = "";
            int cont;
            int j = 0;

            for (i = 0; i < 2; i++)
            {
                nome = Interaction.InputBox("Digite o nome da " + (i + 1) + " pessoa", "Entrada de dados");
                Nomes.Add(nome);
            }

            foreach (string item in Nomes)
            {
                cont = item.Length;
                while (j < item.Length)
                {
                    if (Char.IsWhiteSpace(item[j]))
                    {
                        cont -= 1;
                    }
                    j++;
                }
                lbNomes.Items.Add("O nome: " + item + " tem " + cont + " caracteres");
            }
        }
    }
}
