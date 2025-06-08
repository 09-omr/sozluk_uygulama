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
    public partial class Form5 : Form
    {
        private Form previousForm;
        public Form5(Form previous)
        {
            InitializeComponent();
            previousForm = previous;
        }

        private void Kullanici_Kayit_Load(object sender, EventArgs e)
        {
            pictureBoxKapat.Click += pictureBox2_Click;
        }
        // Kullanıcı kayıt işlemi için butona tıklandığında çalışacak metot.
        private void buttonKayit_Click(object sender, EventArgs e)
        {
            string ad = TxtKullaniciAdi.Text.Trim();
            string sifre = Txtsifre.Text.Trim();
            string email = TxtMail.Text.Trim();


            // Veritabanı bağlantısı için DBManager sınıfındaki kullanici_bilgi veritabınına erişir.
            using (SqlConnection conn = new SqlConnection("Data Source=OMER;Initial Catalog=kullanici_bilgi;Integrated Security=True;"))
            {
                
                if (string.IsNullOrWhiteSpace(TxtKullaniciAdi.Text) ||
                   string.IsNullOrWhiteSpace(Txtsifre.Text) ||
                   string.IsNullOrWhiteSpace(TxtMail.Text))
                { // Kullanıcı adı, şifre ve mail alanlarından herhangi biri boşsa uyarı mesajı gösterir.
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Kullanıcı adı, şifre ve mail bilgilerini veritabanına ekler.
                    SqlCommand cmd = new SqlCommand("kullaniciuyeOl", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@username", ad);
                    cmd.Parameters.AddWithValue("@password", sifre);
                    cmd.Parameters.AddWithValue("@mail", email);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Kaydınız başarı ile gerçekleşmiştir. Aramıza Hoşgeldin " + TxtKullaniciAdi.Text, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                {

                }
            }
        }
        // Kullanıcı kayıt formundan çıkış yapma işlemi için pictureBoxKapat'a tıklandığında çalışacak metot.
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show();
            }
            this.Close();
        }
    }
}
