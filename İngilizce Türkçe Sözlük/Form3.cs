using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje_Deneme_Yanilma;

namespace Proje_Deneme_Yanılma
{
    

    public partial class Form3 : Form
    {
        private Form previousForm;
        public string isim { get; set; }

        public Form3(Form prevForm)
        {
            InitializeComponent();
            this.previousForm = prevForm;
        }
        //Bu buton, geri dönmek için önceki formu gösterir ve bu formu kapatır.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (previousForm != null && !previousForm.IsDisposed)
            {
                previousForm.Show();
            }
            this.Close();

        }

        //Ayarlar butonuna tıklandığında açılır.
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4(this);
            this.Hide();
            fr4.Show();
        }
        //Giriş yapan kullanıcının ismini gösterir.
        private void Form3_Load(object sender, EventArgs e)
        {
            labelKullaniciAd.Text = isim;
            pictureBox1.Click += pictureBox1_Click;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        // Bu buton, kelime ekleme formunu açar.
        private void button4_Click(object sender, EventArgs e)
        {
            Form6 kelimekle = new Form6(this);
            
            this.Hide();

            kelimekle.Show();
        }
        // Bu buton, kelime bulmaca oyununu başlatır.
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 quiz = new Form7(this);
            quiz.Show();
        }
        // Bu buton, wordchain oyununu başlatır.
        private void button2_Click(object sender, EventArgs e)
        {
            Form12 fr12 = new Form12();
            fr12.Show();
            
            
        }
        //Bu buton, wordle oyununu başlatır.
        private void button1_Click(object sender, EventArgs e)
        {
            Form11 fr11 = new Form11(this);
            fr11.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form13 fr13 = new Form13(this); // this = Form3 referansı
            fr13.Show();
            this.Hide(); // Form3 gizlenebilir
        }
    }
}
