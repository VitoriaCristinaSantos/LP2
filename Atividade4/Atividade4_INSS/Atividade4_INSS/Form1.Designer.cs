namespace Atividade4_INSS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomeFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.txtNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.btnVerificarDesc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.chboxCasado = new System.Windows.Forms.CheckBox();
            this.lblAliqINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.txtAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.txtSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.txtAliqIRPF = new System.Windows.Forms.MaskedTextBox();
            this.txtSalLiquido = new System.Windows.Forms.MaskedTextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.txtDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.txtDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(111, 32);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFunc.TabIndex = 0;
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Location = new System.Drawing.Point(111, 78);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSalBruto.TabIndex = 1;
            // 
            // txtNumFilhos
            // 
            this.txtNumFilhos.Location = new System.Drawing.Point(111, 119);
            this.txtNumFilhos.Name = "txtNumFilhos";
            this.txtNumFilhos.Size = new System.Drawing.Size(100, 20);
            this.txtNumFilhos.TabIndex = 2;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(12, 35);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(93, 13);
            this.lblNomeFunc.TabIndex = 3;
            this.lblNomeFunc.Text = "Nome Funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(12, 81);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(66, 13);
            this.lblSalBruto.TabIndex = 4;
            this.lblSalBruto.Text = "Salário bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(12, 122);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(86, 13);
            this.lblNumFilhos.TabIndex = 5;
            this.lblNumFilhos.Text = "Número de filhos";
            // 
            // btnVerificarDesc
            // 
            this.btnVerificarDesc.Location = new System.Drawing.Point(111, 160);
            this.btnVerificarDesc.Name = "btnVerificarDesc";
            this.btnVerificarDesc.Size = new System.Drawing.Size(100, 23);
            this.btnVerificarDesc.TabIndex = 6;
            this.btnVerificarDesc.Text = "Verificar desconto";
            this.btnVerificarDesc.UseVisualStyleBackColor = true;
            this.btnVerificarDesc.Click += new System.EventHandler(this.btnVerificarDesc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnM);
            this.groupBox1.Controls.Add(this.rbtnF);
            this.groupBox1.Location = new System.Drawing.Point(293, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Location = new System.Drawing.Point(36, 29);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(31, 17);
            this.rbtnF.TabIndex = 0;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "F";
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Location = new System.Drawing.Point(36, 64);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(34, 17);
            this.rbtnM.TabIndex = 1;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "M";
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // chboxCasado
            // 
            this.chboxCasado.AutoSize = true;
            this.chboxCasado.Location = new System.Drawing.Point(329, 160);
            this.chboxCasado.Name = "chboxCasado";
            this.chboxCasado.Size = new System.Drawing.Size(62, 17);
            this.chboxCasado.TabIndex = 8;
            this.chboxCasado.Text = "Casado";
            this.chboxCasado.UseVisualStyleBackColor = true;
            // 
            // lblAliqINSS
            // 
            this.lblAliqINSS.AutoSize = true;
            this.lblAliqINSS.Location = new System.Drawing.Point(12, 250);
            this.lblAliqINSS.Name = "lblAliqINSS";
            this.lblAliqINSS.Size = new System.Drawing.Size(75, 13);
            this.lblAliqINSS.TabIndex = 9;
            this.lblAliqINSS.Text = "Alíquota INSS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Location = new System.Drawing.Point(12, 295);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(74, 13);
            this.lblIRPF.TabIndex = 10;
            this.lblIRPF.Text = "Alíquota IRPF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(12, 339);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(76, 13);
            this.lblSalFamilia.TabIndex = 11;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Location = new System.Drawing.Point(12, 377);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(78, 13);
            this.lblSalLiquido.TabIndex = 12;
            this.lblSalLiquido.Text = "Salário Líquido";
            // 
            // txtAliqINSS
            // 
            this.txtAliqINSS.Location = new System.Drawing.Point(111, 247);
            this.txtAliqINSS.Name = "txtAliqINSS";
            this.txtAliqINSS.Size = new System.Drawing.Size(100, 20);
            this.txtAliqINSS.TabIndex = 13;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Location = new System.Drawing.Point(111, 336);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(100, 20);
            this.txtSalFamilia.TabIndex = 14;
            // 
            // txtAliqIRPF
            // 
            this.txtAliqIRPF.Location = new System.Drawing.Point(111, 292);
            this.txtAliqIRPF.Name = "txtAliqIRPF";
            this.txtAliqIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtAliqIRPF.TabIndex = 15;
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Location = new System.Drawing.Point(111, 374);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(100, 20);
            this.txtSalLiquido.TabIndex = 16;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(15, 202);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(38, 13);
            this.lblDados.TabIndex = 17;
            this.lblDados.Text = "Dados";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(259, 250);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescINSS.TabIndex = 18;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(259, 295);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescIRPF.TabIndex = 19;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Location = new System.Drawing.Point(361, 247);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.Size = new System.Drawing.Size(100, 20);
            this.txtDescINSS.TabIndex = 20;
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Location = new System.Drawing.Point(361, 292);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtDescIRPF.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 414);
            this.Controls.Add(this.txtDescIRPF);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtAliqIRPF);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtAliqINSS);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblAliqINSS);
            this.Controls.Add(this.chboxCasado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerificarDesc);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNomeFunc);
            this.Controls.Add(this.txtNumFilhos);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.txtNomeFunc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtNomeFunc;
        private System.Windows.Forms.MaskedTextBox txtSalBruto;
        private System.Windows.Forms.MaskedTextBox txtNumFilhos;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Button btnVerificarDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.CheckBox chboxCasado;
        private System.Windows.Forms.Label lblAliqINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.MaskedTextBox txtAliqINSS;
        private System.Windows.Forms.MaskedTextBox txtSalFamilia;
        private System.Windows.Forms.MaskedTextBox txtAliqIRPF;
        private System.Windows.Forms.MaskedTextBox txtSalLiquido;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.MaskedTextBox txtDescINSS;
        private System.Windows.Forms.MaskedTextBox txtDescIRPF;
    }
}

