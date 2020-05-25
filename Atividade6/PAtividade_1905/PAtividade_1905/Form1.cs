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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            frmExercicio1 frm1 = new frmExercicio1();
            frm1.ShowDialog();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            frmExercicio2 frm2 = new frmExercicio2();
            frm2.ShowDialog();
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            frmExercicio3 frm3 = new frmExercicio3();
            frm3.ShowDialog();
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            frmExercicio4 frm4 = new frmExercicio4();
            frm4.ShowDialog();
        }
    }
}
