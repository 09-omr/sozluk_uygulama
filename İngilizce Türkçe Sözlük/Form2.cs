using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Deneme_Yanılma
{
    public partial class Form2 : Form
    {
        private Form previousForm;
        public Form2(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            

            using (SqlConnection baglanti = DBManager.BaglantiGetir(VeritabaniTipi.KullaniciBilgi))
            {
                if (baglanti == null)
                {
                    MessageBox.Show("Veritabanı bağlantısı sağlanamadı.");
                    return;
                }
                //Giriş yapma işlemi için kullanıcı adı ve şifre kontrolü yapıyoruz.
                SqlCommand komut = new SqlCommand("Select * From tbl_kullanici Where username=@p1 and password=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", Txtsifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {

                    Oturum.userID = Convert.ToInt32(dr["userID"]);
                    Oturum.kullaniciAd = dr["username"].ToString();
                    Oturum.sifre = dr["password"].ToString();
                    //Giriş yapan kullanıcı ID'sini gösteriyoruz.
                    MessageBox.Show("Giriş Yapan Kullanıcı ID: " + dr["userID"].ToString());
                    string kullaniciadi = TxtKullaniciAdi.Text;
                    Form3 fr3 = new Form3(this); 
                    fr3.isim = kullaniciadi;
                    this.Hide();                
                    fr3.Show();

                }
                //Eğer kullanıcı adı ve şifre yanlış ise hata mesajı gösteriyoruz.
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı Ve/Veya Parola!!!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }





          
        

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 kkayit = new Form5(this);
            this.Hide();
            kkayit.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Click += pictureBox1_Click;
        }

        private void linkLabelsifremiunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form8 fr8 = new Form8(this);
            fr8.Show();
        }

        private void TxtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
