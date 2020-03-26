using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4_INSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarDesc_Click(object sender, EventArgs e)
        {
            double var1, var2, aliqINSS, aliqIRPF, salFamilia, salLiq;

            if (string.IsNullOrWhiteSpace(txtNomeFunc.Text))
                MessageBox.Show("Favor inserir o nome!");
            else
                if (double.TryParse(txtSalBruto.Text, out var1) && double.TryParse(txtNumFilhos.Text, out var2))
            {
                if (rbtnF.Checked == true || rbtnM.Checked == true)
                {
                    string nome;
                    nome = txtNomeFunc.Text;

                    if (rbtnF.Checked == true && chboxCasado.Checked == true)
                        lblDados.Text = string.Format("Os descontos do salário da Sra.{0}\nque é casada \ne tem {1} filho(s)", nome, var2);
                    if (rbtnF.Checked == true && chboxCasado.Checked == false)
                        lblDados.Text = string.Format("Os descontos do salário da Sra.{0}\nque é solteira \ne tem {1} filho(s)", nome, var2);
                    if (rbtnF.Checked == false && chboxCasado.Checked == false)
                        lblDados.Text = string.Format("Os descontos de salário do Sr.{0}\nque é solteiro \ne tem {1} filho(s)", nome, var2);
                    if (rbtnF.Checked == false && chboxCasado.Checked == true)
                        lblDados.Text = string.Format("Os descontos do salário do Sr.{0}\nque é casado \ne tem {1} filho(s)", nome, var2);

                    //Alíquota INSS
                    if (var1 <= 800.47)
                    {
                        aliqINSS = var1 * (7.65 / 100);
                        txtAliqINSS.Text = "7.65%";
                    }
                    else if (var1 <= 1050)
                    {
                        aliqINSS = var1 * (8.65 / 100);
                        txtAliqINSS.Text = "8.65%";
                    }
                    else if (var1 <= 1400.77)
                    {
                        aliqINSS = var1 * (9 / 100);
                        txtAliqINSS.Text = "9.00%";
                    }
                    else if (var1 <= 2801.56)
                    {
                        aliqINSS = var1 * (11 / 100);
                        txtAliqINSS.Text = "11%";
                    }
                    else
                    {
                        aliqINSS = 308.17;
                        txtAliqINSS.Text = "Teto";
                    }

                    txtDescINSS.Text = aliqINSS.ToString("N2");


                    //Alíquota IRPF
                    if (var1 <= 1257.12)
                    {
                        aliqIRPF = 0;
                        txtAliqIRPF.Text = "0";
                    }
                    else if (var1 <= 2512.08)
                    {
                        aliqIRPF = var1 * (15 / 100);
                        txtAliqIRPF.Text = "15%";
                    }
                    else
                    {
                        aliqIRPF = var1 * (27.5 / 100);
                        txtAliqIRPF.Text = "27.5%";
                    }

                    txtDescIRPF.Text = aliqIRPF.ToString("N2");

                    //Salário Família
                    if (var1 <= 435.52)
                        salFamilia = var2 * 22.33;
                    else if (var1 <= 654.61)
                        salFamilia = var2 * 15.74;
                    else
                        salFamilia = 0;

                    txtSalFamilia.Text = salFamilia.ToString("N2");

                    //Cálculo do Salário Líquido
                    salLiq = var1 - aliqINSS - aliqIRPF + salFamilia;
                    txtSalLiquido.Text = salLiq.ToString("N2");

                }

                else
                    MessageBox.Show("Selecione o sexo!");

            }
            else
                MessageBox.Show("Dados inválidos!");
        }
    }
}
