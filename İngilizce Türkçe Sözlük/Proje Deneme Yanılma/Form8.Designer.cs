namespace Proje_Deneme_Yanılma
{
    partial class Form8
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
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKodgonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(352, 115);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(191, 22);
            this.TxtMail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen sistemde\r\nkayıtlı e-posta adresinizi\r\ngiriniz:";
            // 
            // btnKodgonder
            // 
            this.btnKodgonder.Font = new System.Drawing.Font("HP Simplified Hans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKodgonder.Location = new System.Drawing.Point(335, 177);
            this.btnKodgonder.Name = "btnKodgonder";
            this.btnKodgonder.Size = new System.Drawing.Size(159, 82);
            this.btnKodgonder.TabIndex = 2;
            this.btnKodgonder.Text = "Kod Gönder";
            this.btnKodgonder.UseVisualStyleBackColor = true;
            this.btnKodgonder.Click += new System.EventHandler(this.btnKodgonder_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKodgonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMail);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKodgonder;
    }
}