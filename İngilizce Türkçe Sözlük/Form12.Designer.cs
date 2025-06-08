namespace Proje_Deneme_Yanılma
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.lblIlkKelime = new System.Windows.Forms.Label();
            this.lblSonKelime = new System.Windows.Forms.Label();
            this.lstBoxKelime = new System.Windows.Forms.ListBox();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.pictureBoxCks = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIlkKelime
            // 
            this.lblIlkKelime.AutoSize = true;
            this.lblIlkKelime.BackColor = System.Drawing.Color.Transparent;
            this.lblIlkKelime.Location = new System.Drawing.Point(215, 21);
            this.lblIlkKelime.Name = "lblIlkKelime";
            this.lblIlkKelime.Size = new System.Drawing.Size(127, 16);
            this.lblIlkKelime.TabIndex = 0;
            this.lblIlkKelime.Text = "Başlangıç Kelimeniz";
            // 
            // lblSonKelime
            // 
            this.lblSonKelime.AutoSize = true;
            this.lblSonKelime.Location = new System.Drawing.Point(215, 415);
            this.lblSonKelime.Name = "lblSonKelime";
            this.lblSonKelime.Size = new System.Drawing.Size(44, 16);
            this.lblSonKelime.TabIndex = 1;
            this.lblSonKelime.Text = "label1";
            // 
            // lstBoxKelime
            // 
            this.lstBoxKelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.lstBoxKelime.ForeColor = System.Drawing.Color.Black;
            this.lstBoxKelime.FormattingEnabled = true;
            this.lstBoxKelime.ItemHeight = 16;
            this.lstBoxKelime.Location = new System.Drawing.Point(12, 3);
            this.lstBoxKelime.Name = "lstBoxKelime";
            this.lstBoxKelime.Size = new System.Drawing.Size(186, 564);
            this.lstBoxKelime.TabIndex = 2;
            this.lstBoxKelime.SelectedIndexChanged += new System.EventHandler(this.lstBoxKelime_SelectedIndexChanged);
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(218, 455);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(181, 22);
            this.txtKelime.TabIndex = 3;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(267, 501);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Ekle";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // pictureBoxCks
            // 
            this.pictureBoxCks.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCks.Image")));
            this.pictureBoxCks.Location = new System.Drawing.Point(379, -1);
            this.pictureBoxCks.Name = "pictureBoxCks";
            this.pictureBoxCks.Size = new System.Drawing.Size(51, 43);
            this.pictureBoxCks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCks.TabIndex = 5;
            this.pictureBoxCks.TabStop = false;
            this.pictureBoxCks.Click += new System.EventHandler(this.pictureBoxCks_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(430, 579);
            this.Controls.Add(this.pictureBoxCks);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtKelime);
            this.Controls.Add(this.lstBoxKelime);
            this.Controls.Add(this.lblSonKelime);
            this.Controls.Add(this.lblIlkKelime);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIlkKelime;
        private System.Windows.Forms.Label lblSonKelime;
        private System.Windows.Forms.ListBox lstBoxKelime;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.PictureBox pictureBoxCks;
    }
}