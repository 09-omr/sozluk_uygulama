namespace Proje_Deneme_Yanılma
{
    partial class Form10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtyenisifre = new System.Windows.Forms.TextBox();
            this.Txtyenisifretekrar = new System.Windows.Forms.TextBox();
            this.btnSifreonay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni şifre tekrar:";
            // 
            // Txtyenisifre
            // 
            this.Txtyenisifre.Location = new System.Drawing.Point(186, 103);
            this.Txtyenisifre.Name = "Txtyenisifre";
            this.Txtyenisifre.Size = new System.Drawing.Size(180, 22);
            this.Txtyenisifre.TabIndex = 1;
            this.Txtyenisifre.TextChanged += new System.EventHandler(this.Txtyenisifre_TextChanged);
            // 
            // Txtyenisifretekrar
            // 
            this.Txtyenisifretekrar.Location = new System.Drawing.Point(186, 145);
            this.Txtyenisifretekrar.Name = "Txtyenisifretekrar";
            this.Txtyenisifretekrar.Size = new System.Drawing.Size(180, 22);
            this.Txtyenisifretekrar.TabIndex = 2;
            // 
            // btnSifreonay
            // 
            this.btnSifreonay.Location = new System.Drawing.Point(186, 212);
            this.btnSifreonay.Name = "btnSifreonay";
            this.btnSifreonay.Size = new System.Drawing.Size(124, 48);
            this.btnSifreonay.TabIndex = 3;
            this.btnSifreonay.Text = "Oluştur";
            this.btnSifreonay.UseVisualStyleBackColor = true;
            this.btnSifreonay.Click += new System.EventHandler(this.btnSifreonay_Click);
            // 
            // Form10
            // 
            this.AcceptButton = this.btnSifreonay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSifreonay);
            this.Controls.Add(this.Txtyenisifretekrar);
            this.Controls.Add(this.Txtyenisifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtyenisifre;
        private System.Windows.Forms.TextBox Txtyenisifretekrar;
        private System.Windows.Forms.Button btnSifreonay;
    }
}