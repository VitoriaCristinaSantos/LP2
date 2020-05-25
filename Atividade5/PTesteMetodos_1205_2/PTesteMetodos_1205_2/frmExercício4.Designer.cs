namespace PTesteMetodos_1205_2
{
    partial class frmExercício4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnNumericos = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnAlfabeticos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(42, 12);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(395, 149);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnNumericos
            // 
            this.btnNumericos.Location = new System.Drawing.Point(42, 183);
            this.btnNumericos.Name = "btnNumericos";
            this.btnNumericos.Size = new System.Drawing.Size(123, 23);
            this.btnNumericos.TabIndex = 1;
            this.btnNumericos.Text = "Caracteres numéricos";
            this.btnNumericos.UseVisualStyleBackColor = true;
            this.btnNumericos.Click += new System.EventHandler(this.btnNumericos_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(194, 183);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(98, 23);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Primeiro branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnAlfabeticos
            // 
            this.btnAlfabeticos.Location = new System.Drawing.Point(321, 183);
            this.btnAlfabeticos.Name = "btnAlfabeticos";
            this.btnAlfabeticos.Size = new System.Drawing.Size(116, 23);
            this.btnAlfabeticos.TabIndex = 3;
            this.btnAlfabeticos.Text = "Carac. alfabéticos";
            this.btnAlfabeticos.UseVisualStyleBackColor = true;
            this.btnAlfabeticos.Click += new System.EventHandler(this.btnAlfabeticos_Click);
            // 
            // frmExercício4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 288);
            this.Controls.Add(this.btnAlfabeticos);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNumericos);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercício4";
            this.Text = "frmExercício4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnNumericos;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnAlfabeticos;
    }
}