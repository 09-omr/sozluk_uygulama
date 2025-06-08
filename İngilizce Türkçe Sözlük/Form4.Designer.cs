namespace Proje_Deneme_Yanılma
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.nudKelimeSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnAyarKaydet = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKelimeSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 62);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quize eklenecek\r\nyeni kelime sayısı:";
            // 
            // nudKelimeSayisi
            // 
            this.nudKelimeSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudKelimeSayisi.Location = new System.Drawing.Point(307, 146);
            this.nudKelimeSayisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudKelimeSayisi.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudKelimeSayisi.Name = "nudKelimeSayisi";
            this.nudKelimeSayisi.Size = new System.Drawing.Size(133, 38);
            this.nudKelimeSayisi.TabIndex = 20;
            this.nudKelimeSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAyarKaydet
            // 
            this.btnAyarKaydet.BackColor = System.Drawing.Color.Gray;
            this.btnAyarKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarKaydet.ForeColor = System.Drawing.Color.White;
            this.btnAyarKaydet.Location = new System.Drawing.Point(307, 225);
            this.btnAyarKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyarKaydet.Name = "btnAyarKaydet";
            this.btnAyarKaydet.Size = new System.Drawing.Size(133, 48);
            this.btnAyarKaydet.TabIndex = 21;
            this.btnAyarKaydet.Text = "Kaydet";
            this.btnAyarKaydet.UseVisualStyleBackColor = false;
            this.btnAyarKaydet.Click += new System.EventHandler(this.btnAyarKaydet_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(423, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 375);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAyarKaydet);
            this.Controls.Add(this.nudKelimeSayisi);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKelimeSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudKelimeSayisi;
        private System.Windows.Forms.Button btnAyarKaydet;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}