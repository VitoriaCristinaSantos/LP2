using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; // para poder usar o InputBox
using System.Collections;

namespace Projeto_2605
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            int x = 0;
            string auxiliar = "";
            string valor = "";

            for (x=0; x<20; x++)
            {
                valor = Interaction.InputBox("Digite o dado" + (x + 1),
                    "Entrada de dados");

                if (int.TryParse(valor, out vetor[x]))
                {
                    auxiliar = auxiliar + "\n" + vetor[x].ToString();
                    auxiliar = vetor[x].ToString() + "\n" + auxiliar; //

                }

                else
                {
                    MessageBox.Show("Número inválido!");
                    x--;
                }
            }

            MessageBox.Show(auxiliar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            int x = 0;
            string auxiliar = "";
            string valor = "";

            for (x=0; x<20; x++)
            {
                valor = Interaction.InputBox("Digite o dado da posição: " + (x + 1),
                    "Digitação dos dados");
                if (!int.TryParse(valor, out vetor [x]))
                {
                    MessageBox.Show("Número inválido!");
                    x--;
                }
            }
            Array.Reverse(vetor);

            for (x = 0; x < 20; x++)
                auxiliar += vetor[x] + "\n";

            MessageBox.Show(auxiliar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] qntd = new double[10];
            double[] preco = new double[10];
            string auxiliar = "";
            bool prox;



            for (int x = 0; x < 10; x++)
            {
                prox = false;
                while (!prox)
                {
                    auxiliar = Interaction.InputBox("Digite a quantidade:" + (x + 1), "Entradade dados");



                    if (!double.TryParse(auxiliar, out qntd[x]))
                    {
                        MessageBox.Show("Numero Invalido!");
                    }
                    else
                    {
                        prox = true;
                    }
                }



                prox = false;
                while (!prox)
                {
                    auxiliar = Interaction.InputBox("Digite o preço:" + (x + 1), "Entradade dados");



                    if (!double.TryParse(auxiliar, out preco[x]))
                    {
                        MessageBox.Show("Numero Invalido!");
                    }
                    else
                    {
                        prox = true;
                    }
                }
            }
            double total = 0;
            for (int x = 0; x < 10; x++)
            {
                total += qntd[x] * preco[x];
            }



            MessageBox.Show("O faturamento total é de: " + total.ToString("N2"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior",
                                    "Leonardo", "José", "Nelma", "Tobby"};

            Int32 I, Total = 0;
            Int32 N = Alunos.Length;

            for (I = 0; I < N - 1; I++)
                Total += Alunos[I].Length;
            MessageBox.Show(Total.ToString("N2"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList();

            alunos.Add("Ana");
            alunos.Add("André");
            alunos.Add("Débora");
            alunos.Add("Fátima");
            alunos.Add("João");
            alunos.Add("Janete");
            alunos.Add("Otávio");
            alunos.Add("Marcelo");
            alunos.Add("Pedro");
            alunos.Add("Thaís");

            alunos.Remove("Otávio");

            string nomes = "";

            foreach (string nome in alunos)
                nomes += nome + "\n";

            MessageBox.Show(nomes);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i, j;
            string nota;
            double[,] notas = new double[20, 3];
            double media;

            for (i = 0; i < 19; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    nota = Interaction.InputBox("Entre com a nota do aluno " + (i + 1) + ". " + "Nota " + (j + 1) + ":");
                    if (!double.TryParse(nota, out notas[i, j]))
                    {
                        MessageBox.Show("Número inválido!");
                        j--;
                        continue;
                    }

                }
            }

            for (i = 0; i < 19; i++)
            {
                media = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
                MessageBox.Show("Aluno " + (i + 1) + ": média: " + media + "\n");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Ex7 Exercicio7 = new Ex7();
            Exercicio7.ShowDialog();
        }
    }
}
