namespace CalculadoraPesoIdeal
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPesoAtual = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.txtPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.rbuttonMasculino = new System.Windows.Forms.RadioButton();
            this.rbuttonFeminino = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(12, 19);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPesoAtual
            // 
            this.lblPesoAtual.AutoSize = true;
            this.lblPesoAtual.Location = new System.Drawing.Point(12, 58);
            this.lblPesoAtual.Name = "lblPesoAtual";
            this.lblPesoAtual.Size = new System.Drawing.Size(58, 13);
            this.lblPesoAtual.TabIndex = 4;
            this.lblPesoAtual.Text = "Peso Atual";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(99, 16);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 6;
            // 
            // txtPesoAtual
            // 
            this.txtPesoAtual.Location = new System.Drawing.Point(99, 55);
            this.txtPesoAtual.Name = "txtPesoAtual";
            this.txtPesoAtual.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAtual.TabIndex = 7;
            // 
            // rbuttonMasculino
            // 
            this.rbuttonMasculino.AutoSize = true;
            this.rbuttonMasculino.Location = new System.Drawing.Point(238, 19);
            this.rbuttonMasculino.Name = "rbuttonMasculino";
            this.rbuttonMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbuttonMasculino.TabIndex = 9;
            this.rbuttonMasculino.TabStop = true;
            this.rbuttonMasculino.Text = "Masculino";
            this.rbuttonMasculino.UseVisualStyleBackColor = true;
            // 
            // rbuttonFeminino
            // 
            this.rbuttonFeminino.AutoSize = true;
            this.rbuttonFeminino.Location = new System.Drawing.Point(238, 42);
            this.rbuttonFeminino.Name = "rbuttonFeminino";
            this.rbuttonFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbuttonFeminino.TabIndex = 10;
            this.rbuttonFeminino.TabStop = true;
            this.rbuttonFeminino.Text = "Feminino";
            this.rbuttonFeminino.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(124, 97);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(230, 97);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 97);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 146);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rbuttonFeminino);
            this.Controls.Add(this.rbuttonMasculino);
            this.Controls.Add(this.txtPesoAtual);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblPesoAtual);
            this.Controls.Add(this.lblAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPesoAtual;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.MaskedTextBox txtPesoAtual;
        private System.Windows.Forms.RadioButton rbuttonMasculino;
        private System.Windows.Forms.RadioButton rbuttonFeminino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}

