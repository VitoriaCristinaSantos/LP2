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

namespace P0030481921013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            double[,] tabVendas = new double[3, 4];
            string vTabela = "";
            int i, j;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    vTabela = Interaction.InputBox("Por favor entre com o valor das vendas do mês " + (i + 1) + ", semana " + (j + 1), "Digite os dados");
                    if (!double.TryParse(vTabela, out tabVendas[i, j]))
                    {
                        MessageBox.Show("Número inválido, tente novamente!!");
                        j--;
                    }
                }
            }

            double totSem, totMes, totGeral, y = 0, yMes = 0;
            int k, l;

            for (k = 0; k < 3; k++)
            {
                for (l = 0; l < 4; l++)
                {
                    totSem = tabVendas[k, l];
                    lstbxDados.Items.Add("Total do mês: " + (k + 1) + " Semana: " + (l + 1) + ": " + totSem.ToString("N2"));
                    y += totSem;
                }
                totMes = y;
                lstbxDados.Items.Add(">> Total do Mês: " + totMes.ToString("N2"));
                lstbxDados.Items.Add("-----------------------");
                y = 0;
                yMes += totMes;
            }
            totGeral = yMes;
            lstbxDados.Items.Add("TotalGeral: " + totGeral.ToString("N2"));
        }

    }
}

        
    

