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
using System.Windows.Forms;

namespace Proje_Deneme_Yanılma
{
    public partial class Form5 : Form
    {
        private Form previousForm;
        public Form5()
        {
            InitializeComponent();
            previousForm = Application.OpenForms.OfType<Form2>().FirstOrDefault(); 
        }

        private void Kullanici_Kayit_Load(object sender, EventArgs e)
        {
            pictureBox2.Click += pictureBox2_Click;
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            string ad = TxtKullaniciAdi.Text.Trim();
            string sifre = Txtsifre.Text.Trim();
            string email = TxtMail.Text.Trim();


            using (SqlConnection conn = new SqlConnection("Data Source=OMER;Initial Catalog=kullanici_bilgi;Integrated Security=True;"))
            {
                if (string.IsNullOrWhiteSpace(TxtKullaniciAdi.Text) ||
                    string.IsNullOrWhiteSpace(Txtsifre.Text) ||
                    string.IsNullOrWhiteSpace(TxtMail.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
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

                        MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        


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
    
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
        public Form5(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }
    }
}
