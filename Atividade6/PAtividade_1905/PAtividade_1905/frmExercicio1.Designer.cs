namespace PAtividade_1905
{
    partial class frmExercicio1
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
            this.btnBrancos = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnParDeLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(21, 23);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(280, 143);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnBrancos
            // 
            this.btnBrancos.Location = new System.Drawing.Point(318, 23);
            this.btnBrancos.Name = "btnBrancos";
            this.btnBrancos.Size = new System.Drawing.Size(159, 23);
            this.btnBrancos.TabIndex = 1;
            this.btnBrancos.Text = "Espaços em branco";
            this.btnBrancos.UseVisualStyleBackColor = true;
            this.btnBrancos.Click += new System.EventHandler(this.btnBrancos_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(318, 78);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(159, 23);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "Quantidade de letras R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnParDeLetras
            // 
            this.btnParDeLetras.Location = new System.Drawing.Point(318, 133);
            this.btnParDeLetras.Name = "btnParDeLetras";
            this.btnParDeLetras.Size = new System.Drawing.Size(159, 23);
            this.btnParDeLetras.TabIndex = 3;
            this.btnParDeLetras.Text = "Quantidade de pares";
            this.btnParDeLetras.UseVisualStyleBackColor = true;
            this.btnParDeLetras.Click += new System.EventHandler(this.btnParDeLetras_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 198);
            this.Controls.Add(this.btnParDeLetras);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnBrancos);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnBrancos;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnParDeLetras;
    }
}