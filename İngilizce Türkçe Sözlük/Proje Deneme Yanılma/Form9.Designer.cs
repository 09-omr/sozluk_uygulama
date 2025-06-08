namespace Proje_Deneme_Yanılma
{
    partial class Form9
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
            this.TxtKod = new System.Windows.Forms.TextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen E-Mailinize\r\ngelen doğrulama\r\nkodunu giriniz:";
            // 
            // TxtKod
            // 
            this.TxtKod.Location = new System.Drawing.Point(289, 95);
            this.TxtKod.Name = "TxtKod";
            this.TxtKod.Size = new System.Drawing.Size(188, 22);
            this.TxtKod.TabIndex = 1;
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(333, 143);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(100, 52);
            this.btnDogrula.TabIndex = 2;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 421);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.TxtKod);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKod;
        private System.Windows.Forms.Button btnDogrula;
    }
}