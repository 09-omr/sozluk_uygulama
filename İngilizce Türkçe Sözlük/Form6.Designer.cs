namespace Proje_Deneme_Yanılma
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.TxtEnglish = new System.Windows.Forms.TextBox();
            this.TxtTürkçe = new System.Windows.Forms.TextBox();
            this.btnKelimeEkle = new System.Windows.Forms.Button();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TxtllkHarf = new System.Windows.Forms.TextBox();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.pictureBoxKapat = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEnglish
            // 
            this.TxtEnglish.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEnglish.Location = new System.Drawing.Point(299, 110);
            this.TxtEnglish.Name = "TxtEnglish";
            this.TxtEnglish.Size = new System.Drawing.Size(379, 46);
            this.TxtEnglish.TabIndex = 2;
            // 
            // TxtTürkçe
            // 
            this.TxtTürkçe.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTürkçe.Location = new System.Drawing.Point(299, 169);
            this.TxtTürkçe.Name = "TxtTürkçe";
            this.TxtTürkçe.Size = new System.Drawing.Size(379, 46);
            this.TxtTürkçe.TabIndex = 3;
            // 
            // btnKelimeEkle
            // 
            this.btnKelimeEkle.BackColor = System.Drawing.Color.Gold;
            this.btnKelimeEkle.Location = new System.Drawing.Point(330, 298);
            this.btnKelimeEkle.Name = "btnKelimeEkle";
            this.btnKelimeEkle.Size = new System.Drawing.Size(288, 102);
            this.btnKelimeEkle.TabIndex = 5;
            this.btnKelimeEkle.Text = "Kelime Ekle";
            this.btnKelimeEkle.UseVisualStyleBackColor = false;
            this.btnKelimeEkle.Click += new System.EventHandler(this.btnKelimeEkle_Click);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnResimEkle.Location = new System.Drawing.Point(799, 296);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(182, 65);
            this.btnResimEkle.TabIndex = 6;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = false;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TxtllkHarf
            // 
            this.TxtllkHarf.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtllkHarf.Location = new System.Drawing.Point(299, 51);
            this.TxtllkHarf.Name = "TxtllkHarf";
            this.TxtllkHarf.Size = new System.Drawing.Size(379, 46);
            this.TxtllkHarf.TabIndex = 1;
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Items.AddRange(new object[] {
            "Adverb",
            "Verb",
            "Preposition",
            "Determiner",
            "Adjective",
            "Noun",
            "Pronoun",
            "Adverb",
            "Proper Noun",
            "Conjunction",
            "Masculine Pronoun",
            "Interjection",
            "Numeral"});
            this.comboBoxTip.Location = new System.Drawing.Point(299, 228);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(379, 46);
            this.comboBoxTip.TabIndex = 4;
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.Location = new System.Drawing.Point(717, 51);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(347, 200);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim.TabIndex = 4;
            this.pictureBoxResim.TabStop = false;
            // 
            // pictureBoxKapat
            // 
            this.pictureBoxKapat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKapat.Image")));
            this.pictureBoxKapat.Location = new System.Drawing.Point(1057, 0);
            this.pictureBoxKapat.Name = "pictureBoxKapat";
            this.pictureBoxKapat.Size = new System.Drawing.Size(49, 43);
            this.pictureBoxKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKapat.TabIndex = 31;
            this.pictureBoxKapat.TabStop = false;
            this.pictureBoxKapat.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 34;
            this.label1.Text = "İngilizce İlk Harf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 35;
            this.label2.Text = "English:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 37;
            this.label4.Text = "Türkçe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 27);
            this.label5.TabIndex = 38;
            this.label5.Text = "Kelime Türü:";
            // 
            // Form6
            // 
            this.AcceptButton = this.btnKelimeEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1106, 515);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxKapat);
            this.Controls.Add(this.comboBoxTip);
            this.Controls.Add(this.TxtllkHarf);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.btnKelimeEkle);
            this.Controls.Add(this.pictureBoxResim);
            this.Controls.Add(this.TxtTürkçe);
            this.Controls.Add(this.TxtEnglish);
            this.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.KelimeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEnglish;
        private System.Windows.Forms.TextBox TxtTürkçe;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.Button btnKelimeEkle;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TxtllkHarf;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.PictureBox pictureBoxKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}