namespace P0030481921013
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
            this.Verificar = new System.Windows.Forms.Button();
            this.lstbxDados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Verificar
            // 
            this.Verificar.Location = new System.Drawing.Point(53, 120);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(126, 27);
            this.Verificar.TabIndex = 0;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // lstbxDados
            // 
            this.lstbxDados.FormattingEnabled = true;
            this.lstbxDados.Location = new System.Drawing.Point(246, 12);
            this.lstbxDados.Name = "lstbxDados";
            this.lstbxDados.Size = new System.Drawing.Size(239, 251);
            this.lstbxDados.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 268);
            this.Controls.Add(this.lstbxDados);
            this.Controls.Add(this.Verificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.ListBox lstbxDados;
    }
}

