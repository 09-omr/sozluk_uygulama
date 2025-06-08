using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Deneme_Yanılma
{
    public partial class Form12 : Form
    {

        private string baglantiCumlesi = "Server=omer;Database=sozluk_vocabulary;Trusted_Connection=True;";
        private string sonKelime = "";
        private string ilkKelime = "";


        public Form12()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form12_Load);
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT TOP 1 en FROM vocabulary_clean_for_sql WHERE en IS NOT NULL ORDER BY NEWID()";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        ilkKelime = reader["en"].ToString().ToLower();
                        sonKelime = ilkKelime;
                        lblIlkKelime.Text = "İlk Kelime: " + ilkKelime;
                        lstBoxKelime.Items.Add(ilkKelime);
                        lblSonKelime.Text = "Son Yazılan Kelime: " + sonKelime;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string girilenKelime = txtKelime.Text.Trim().ToLower();

            if (girilenKelime.Length == 0)
            {
                MessageBox.Show("Lütfen bir kelime girin.");
                return;
            }

            // Tekrar kullanımı kontrol et (ilkKelime, sonKelime veya listede var mı?)
            if (girilenKelime == ilkKelime ||
                girilenKelime == sonKelime ||
                lstBoxKelime.Items.Cast<string>().Any(x => x.ToLower() == girilenKelime))
            {
                MessageBox.Show("Bu kelime daha önce kullanıldı.");
                return;
            }

            // Son harf kontrolü
            if (string.IsNullOrEmpty(sonKelime) || girilenKelime[0] != sonKelime[sonKelime.Length - 1])
            {
                MessageBox.Show("Kelime yanlış harfle başlıyor.");
                return;
            }

            // Veritabanında var mı?
            using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM vocabulary_clean_for_sql WHERE en = @kelime";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kelime", girilenKelime);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        sonKelime = girilenKelime;
                        lstBoxKelime.Items.Add(girilenKelime);
                        lblSonKelime.Text = "Son Yazılan Kelime: " + sonKelime;
                        txtKelime.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Bu kelime veritabanında bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }

        private void lstBoxKelime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxCks_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
