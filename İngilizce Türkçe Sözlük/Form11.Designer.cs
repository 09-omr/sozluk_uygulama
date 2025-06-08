namespace Proje_Deneme_Yanılma
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.pictureBoxCks = new System.Windows.Forms.PictureBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCks)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCks
            // 
            this.pictureBoxCks.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCks.Image")));
            this.pictureBoxCks.Location = new System.Drawing.Point(767, -2);
            this.pictureBoxCks.Name = "pictureBoxCks";
            this.pictureBoxCks.Size = new System.Drawing.Size(70, 54);
            this.pictureBoxCks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCks.TabIndex = 0;
            this.pictureBoxCks.TabStop = false;
            this.pictureBoxCks.Click += new System.EventHandler(this.pictureBoxCks_Click);
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(588, 183);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(137, 65);
            this.btnTahmin.TabIndex = 1;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Location = new System.Drawing.Point(516, 143);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(288, 34);
            this.txtTahmin.TabIndex = 2;
            this.txtTahmin.TextChanged += new System.EventHandler(this.txtTahmin_TextChanged);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(837, 455);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.pictureBoxCks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCks;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.TextBox txtTahmin;
    }
}