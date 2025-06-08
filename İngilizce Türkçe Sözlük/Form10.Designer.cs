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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
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
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni şifre tekrar:";
            // 
            // Txtyenisifre
            // 
            this.Txtyenisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtyenisifre.Location = new System.Drawing.Point(279, 69);
            this.Txtyenisifre.Name = "Txtyenisifre";
            this.Txtyenisifre.Size = new System.Drawing.Size(141, 34);
            this.Txtyenisifre.TabIndex = 2;
            // 
            // Txtyenisifretekrar
            // 
            this.Txtyenisifretekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtyenisifretekrar.Location = new System.Drawing.Point(279, 127);
            this.Txtyenisifretekrar.Name = "Txtyenisifretekrar";
            this.Txtyenisifretekrar.Size = new System.Drawing.Size(141, 34);
            this.Txtyenisifretekrar.TabIndex = 3;
            // 
            // btnSifreonay
            // 
            this.btnSifreonay.Location = new System.Drawing.Point(289, 183);
            this.btnSifreonay.Name = "btnSifreonay";
            this.btnSifreonay.Size = new System.Drawing.Size(122, 35);
            this.btnSifreonay.TabIndex = 4;
            this.btnSifreonay.Text = "Oluştur";
            this.btnSifreonay.UseVisualStyleBackColor = true;
            this.btnSifreonay.Click += new System.EventHandler(this.btnSifreonay_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(518, 268);
            this.Controls.Add(this.btnSifreonay);
            this.Controls.Add(this.Txtyenisifretekrar);
            this.Controls.Add(this.Txtyenisifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
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