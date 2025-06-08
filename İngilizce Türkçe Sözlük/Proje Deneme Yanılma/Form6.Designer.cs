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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKelimeEkle = new System.Windows.Forms.Button();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtllkHarf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEnglish
            // 
            this.TxtEnglish.Location = new System.Drawing.Point(396, 174);
            this.TxtEnglish.Name = "TxtEnglish";
            this.TxtEnglish.Size = new System.Drawing.Size(379, 53);
            this.TxtEnglish.TabIndex = 2;
            // 
            // TxtTürkçe
            // 
            this.TxtTürkçe.Location = new System.Drawing.Point(396, 243);
            this.TxtTürkçe.Name = "TxtTürkçe";
            this.TxtTürkçe.Size = new System.Drawing.Size(379, 53);
            this.TxtTürkçe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "English:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(228, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Türkçe:";
            // 
            // btnKelimeEkle
            // 
            this.btnKelimeEkle.BackColor = System.Drawing.Color.Gold;
            this.btnKelimeEkle.Location = new System.Drawing.Point(467, 411);
            this.btnKelimeEkle.Name = "btnKelimeEkle";
            this.btnKelimeEkle.Size = new System.Drawing.Size(288, 102);
            this.btnKelimeEkle.TabIndex = 6;
            this.btnKelimeEkle.Text = "Kelime Ekle";
            this.btnKelimeEkle.UseVisualStyleBackColor = false;
            this.btnKelimeEkle.Click += new System.EventHandler(this.btnKelimeEkle_Click);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnResimEkle.Location = new System.Drawing.Point(906, 411);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(182, 65);
            this.btnResimEkle.TabIndex = 5;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = false;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(229, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 56);
            this.label3.TabIndex = 7;
            this.label3.Text = "İngilizce \r\nİlk Harf:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TxtllkHarf
            // 
            this.TxtllkHarf.Location = new System.Drawing.Point(396, 98);
            this.TxtllkHarf.Name = "TxtllkHarf";
            this.TxtllkHarf.Size = new System.Drawing.Size(379, 53);
            this.TxtllkHarf.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(228, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 70);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kelime \r\nTürü:";
            // 
            // comboBoxTip
            // 
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
            this.comboBoxTip.Location = new System.Drawing.Point(396, 317);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(379, 53);
            this.comboBoxTip.TabIndex = 4;
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.Location = new System.Drawing.Point(815, 135);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(347, 200);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim.TabIndex = 4;
            this.pictureBoxResim.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1312, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form6
            // 
            this.AcceptButton = this.btnKelimeEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1360, 525);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxTip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtllkHarf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.btnKelimeEkle);
            this.Controls.Add(this.pictureBoxResim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTürkçe);
            this.Controls.Add(this.TxtEnglish);
            this.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "Form6";
            this.Text = "KelimeEkle";
            this.Load += new System.EventHandler(this.KelimeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEnglish;
        private System.Windows.Forms.TextBox TxtTürkçe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.Button btnKelimeEkle;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtllkHarf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}