using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Deneme_Yanılma
{
    public partial class Form4 : Form
    {
        private Form previousForm;
        public Form4(Form previous)
        {
            InitializeComponent();
            previousForm = previous;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAyarKaydet_Click(object sender, EventArgs e)
        {
            Ayarlar.YeniKelimeSayisi = (int)nudKelimeSayisi.Value;
            MessageBox.Show("Ayar kaydedildi.");
             
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(this);
            this.Close();
            fr3.Show();
        }
    }
}
