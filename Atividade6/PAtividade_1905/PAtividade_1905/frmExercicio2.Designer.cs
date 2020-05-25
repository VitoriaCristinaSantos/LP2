namespace PAtividade_1905
{
    partial class frmExercicio2
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
            this.btnGerarH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.txtNumeroH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGerarH
            // 
            this.btnGerarH.Location = new System.Drawing.Point(89, 65);
            this.btnGerarH.Name = "btnGerarH";
            this.btnGerarH.Size = new System.Drawing.Size(75, 23);
            this.btnGerarH.TabIndex = 0;
            this.btnGerarH.Text = "Gerar H";
            this.btnGerarH.UseVisualStyleBackColor = true;
            this.btnGerarH.Click += new System.EventHandler(this.btnGerarH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número N";
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Location = new System.Drawing.Point(76, 39);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroN.TabIndex = 2;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(12, 110);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(55, 13);
            this.lblH.TabIndex = 3;
            this.lblH.Text = "Número H";
            // 
            // txtNumeroH
            // 
            this.txtNumeroH.Location = new System.Drawing.Point(76, 107);
            this.txtNumeroH.Name = "txtNumeroH";
            this.txtNumeroH.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroH.TabIndex = 4;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 156);
            this.Controls.Add(this.txtNumeroH);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.txtNumeroN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarH);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtNumeroH;
    }
}