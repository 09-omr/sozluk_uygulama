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

        public Form3(Form previous)
        {
            InitializeComponent();
            previousForm = previous;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();

            this.Close();
            fr2.Show();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4(this);
            
            this.Close();
            fr4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labelKullaniciAd.Text = isim;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 kelimekle = new Form6(this);
            
            this.Hide();

            kelimekle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 quiz = new Form7(this);

            this.Hide();

            quiz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
