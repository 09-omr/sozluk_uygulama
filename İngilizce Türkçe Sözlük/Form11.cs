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
    public partial class Form11 : Form
    {

        string connectionString = "Server=omer;Database=sozluk_vocabulary;Trusted_Connection=True;";
        string gizliKelime = "";
        Label[,] harfKutulari = new Label[6, 5];
        int tahminSayisi = 0;
        private Form previousForm;



        public Form11(Form previous)
        {
            InitializeComponent();
            previousForm = previous;
            this.AutoScroll = true;
        }


        private void Form11_Load(object sender, EventArgs e)
        {
            GizliKelimeyiSec();
            GridHazirla();
            btnTahmin.Click += btnTahmin_Click;
        }

        private void GridHazirla()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Label lbl = new Label();
                    lbl.Size = new Size(40, 40);
                    lbl.Location = new Point(50 * j + 10, 50 * i + 10);
                    lbl.Font = new Font("Arial", 18, FontStyle.Bold);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(lbl);
                    lbl.BringToFront();
                    harfKutulari[i, j] = lbl;
                }
            }
        }
        

        private void GizliKelimeyiSec()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string kelime = "";
                Random rnd = new Random();
                while (true)
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 en FROM vocabulary_clean_for_sql ORDER BY NEWID()", conn);
                    object sonuc = cmd.ExecuteScalar();

                    if (sonuc != null)
                    {
                        kelime = sonuc.ToString().Trim().ToUpper();

                        if (kelime.Length == 5 && kelime.All(char.IsLetter))
                        {
                            gizliKelime = kelime;
                            break;
                        }
                    }
                }
            }
        }


        private void btnTahmin_Click(object sender, EventArgs e)
        {
            string tahmin = txtTahmin.Text.Trim().ToUpper();
            if (tahmin.Length != 5)
            {
                MessageBox.Show("5 harfli bir kelime giriniz.");
                return;
            }

            KelimeyiKontrolEt(tahmin);
        }

        private void KelimeyiKontrolEt(string tahmin)
        {
            for (int i = 0; i < 5; i++)
            {
                harfKutulari[tahminSayisi, i].Text = tahmin[i].ToString();

                if (tahmin[i] == gizliKelime[i])
                {
                    harfKutulari[tahminSayisi, i].BackColor = Color.Green;
                }
                else if (gizliKelime.Contains(tahmin[i]))
                {
                    harfKutulari[tahminSayisi, i].BackColor = Color.Gold;
                }
                else
                {
                    harfKutulari[tahminSayisi, i].BackColor = Color.Gray;
                }
            }

            tahminSayisi++;

            if (tahmin == gizliKelime)
            {
                MessageBox.Show("Tebrikler! Doğru bildiniz.");
                YeniOyunBaslat();  // Oyunu yeniden başlat
            }
            else if (tahminSayisi >= 6)
            {
                MessageBox.Show("Maalesef bilemediniz. Kelime: " + gizliKelime);
                YeniOyunBaslat();  // Oyunu yeniden başlat
            }

        }


        private void YeniOyunBaslat()
        {
            gizliKelime = "";
            tahminSayisi = 0;
            GizliKelimeyiSec();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    harfKutulari[i, j].Text = "";
                    harfKutulari[i, j].BackColor = SystemColors.Control;
                }
            }
        }







        private void pictureBoxCks_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void txtTahmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load_1(object sender, EventArgs e)
        {

        }
    }
}
