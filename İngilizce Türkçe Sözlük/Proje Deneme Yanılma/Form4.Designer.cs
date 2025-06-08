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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 50);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quize eklenecek\r\nyeni kelime sayısı:";
            // 
            // nudKelimeSayisi
            // 
            this.nudKelimeSayisi.Location = new System.Drawing.Point(229, 115);
            this.nudKelimeSayisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudKelimeSayisi.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudKelimeSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKelimeSayisi.Name = "nudKelimeSayisi";
            this.nudKelimeSayisi.Size = new System.Drawing.Size(100, 20);
            this.nudKelimeSayisi.TabIndex = 20;
            this.nudKelimeSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAyarKaydet
            // 
            this.btnAyarKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarKaydet.Location = new System.Drawing.Point(126, 207);
            this.btnAyarKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAyarKaydet.Name = "btnAyarKaydet";
            this.btnAyarKaydet.Size = new System.Drawing.Size(100, 39);
            this.btnAyarKaydet.TabIndex = 21;
            this.btnAyarKaydet.Text = "Kaydet";
            this.btnAyarKaydet.UseVisualStyleBackColor = true;
            this.btnAyarKaydet.Click += new System.EventHandler(this.btnAyarKaydet_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(314, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(362, 323);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAyarKaydet);
            this.Controls.Add(this.nudKelimeSayisi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
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