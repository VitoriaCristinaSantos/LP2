namespace Projeto_2605
{
    partial class Ex7
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
            this.lbNomes = new System.Windows.Forms.ListBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNomes
            // 
            this.lbNomes.FormattingEnabled = true;
            this.lbNomes.Location = new System.Drawing.Point(249, 12);
            this.lbNomes.Name = "lbNomes";
            this.lbNomes.Size = new System.Drawing.Size(169, 238);
            this.lbNomes.TabIndex = 0;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(70, 115);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Ex7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 272);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lbNomes);
            this.Name = "Ex7";
            this.Text = "Ex7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNomes;
        private System.Windows.Forms.Button btnExecutar;
    }
}