// Gerekli using ifadeleri:
using Proje_Deneme_Yanılma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsRadioButton = System.Windows.Forms.RadioButton; // Ambiguity çözümü

namespace Proje_Deneme_Yanilma
{
    public partial class Form7 : Form
    {
        List<int> quizKelimeleri = new List<int>();
        int aktifIndex = 0;
        Random rnd = new Random();
        string correctAnswer = "";
        int correctOptionIndex = -1;
        int currentWordID = -1;
        private Form previousForm;

        public Form7(Form previous)
        {
            InitializeComponent();
            previousForm = previous;
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            KelimeListesiniHazirla();
            if (quizKelimeleri.Count > 0)
            {
                aktifIndex = 0;
                SoruYukle(quizKelimeleri[aktifIndex]);
                pictureBox2.Click += pictureBox2_Click;
            }
        }

        private void KelimeListesiniHazirla()
        {
            int aktifKullaniciId = Oturum.userID;
            int yeniKelimeSayisi = Ayarlar.YeniKelimeSayisi;

            Dictionary<int, TimeSpan> zamanlar = new Dictionary<int, TimeSpan>()
            {
                { 1, TimeSpan.Zero },
                { 2, TimeSpan.FromDays(1) },
                { 3, TimeSpan.FromDays(7) },
                { 4, TimeSpan.FromDays(30) },
                { 5, TimeSpan.FromDays(90) },
                { 6, TimeSpan.FromDays(180) },
            };

            quizKelimeleri.Clear();

            using (SqlConnection bagl = DBManager.BaglantiGetir(VeritabaniTipi.SozlukVocabulary))
            {
                if (bagl == null)
                {
                    MessageBox.Show("Kullanıcı veritabanına bağlanılamadı.");
                    return;
                }

                SqlCommand testCmd = new SqlCommand("SELECT TOP 1 ID FROM vocabulary_clean_for_sql", bagl);
                object testResult = testCmd.ExecuteScalar();
                if (testResult == null)
                {
                    MessageBox.Show("Tabloya erişilemiyor veya tablo boş.");
                    return;
                }

                SqlCommand zamanCmd = new SqlCommand("SELECT WordID, Derece, SonDogruBilme FROM quiz_ilerleme WHERE userID = @user", bagl);
                zamanCmd.Parameters.AddWithValue("@user", aktifKullaniciId);
                using (SqlDataReader dr = zamanCmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int derece = Convert.ToInt32(dr["Derece"]);
                        DateTime sonDogru = Convert.ToDateTime(dr["SonDogruBilme"]);
                        int WordID = Convert.ToInt32(dr["WordID"]);

                        if (derece >= 1 && derece <= 6 && DateTime.Now >= sonDogru.Add(zamanlar[derece]))
                        {
                            quizKelimeleri.Add(WordID);
                        }
                    }
                }

                int eksikSayi = yeniKelimeSayisi - quizKelimeleri.Count;
                if (eksikSayi > 0)
                {
                    SqlCommand yeniKelimeCmd = new SqlCommand(@"
                        SELECT TOP (@sayi) ID FROM dbo.vocabulary_clean_for_sql
                        WHERE ID NOT IN (
                            SELECT WordID FROM quiz_ilerleme WHERE userID = @user
                        ) ORDER BY NEWID()", bagl);

                    yeniKelimeCmd.Parameters.AddWithValue("@user", aktifKullaniciId);
                    yeniKelimeCmd.Parameters.AddWithValue("@sayi", eksikSayi);

                    using (SqlDataReader drYeni = yeniKelimeCmd.ExecuteReader())
                    {
                        while (drYeni.Read())
                        {
                            int WordID = Convert.ToInt32(drYeni["ID"]);
                            quizKelimeleri.Add(WordID);
                        }
                    }
                }
            }

            if (quizKelimeleri.Count > 0)
            {
                SoruYukle(quizKelimeleri[0]);
            }
            else
            {
                MessageBox.Show("Zamanı gelmiş veya yeni eklenecek kelime bulunamadı.");
            }
        }

        void SoruYukle(int WordID)
        {
            using (SqlConnection bagl = DBManager.BaglantiGetir(VeritabaniTipi.SozlukVocabulary))
            {
                if (bagl == null)
                {
                    MessageBox.Show("Sözlük veritabanına bağlanılamadı.");
                    return;
                }

                SqlCommand cmd = new SqlCommand("SELECT ID, en, tr, image FROM dbo.vocabulary_clean_for_sql WHERE ID = @id", bagl);
                cmd.Parameters.AddWithValue("@id", WordID);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        string en = dr["en"].ToString();
                        string tr = dr["tr"].ToString();
                        string resimYolu = dr["image"].ToString();
                        currentWordID = Convert.ToInt32(dr["ID"]);

                        bool ingilizceSorulsunMu = rnd.Next(0, 2) == 0;
                        List<string> secenekler = new List<string>();
                        correctAnswer = ingilizceSorulsunMu ? tr : en;

                        labelsoru.Text = ingilizceSorulsunMu
                            ? $"Bu İngilizce kelimenin Türkçe karşılığı nedir?\n→ {en}"
                            : $"Bu Türkçe kelimenin İngilizcesi nedir?\n→ {tr}";

                        pictureBoxSoru.Image = File.Exists(resimYolu) ? Image.FromFile(resimYolu) : null;
                    }
                }

                List<string> yanlisSecenekler = new List<string>();
                bool ingSor = rnd.Next(0, 2) == 0;
                using (SqlCommand yanlisCmd = new SqlCommand(ingSor ?
                    "SELECT TOP 3 tr FROM dbo.vocabulary_clean_for_sql WHERE tr != @dogru ORDER BY NEWID()" :
                    "SELECT TOP 3 en FROM dbo.vocabulary_clean_for_sql WHERE en != @dogru ORDER BY NEWID()", bagl))
                {
                    yanlisCmd.Parameters.AddWithValue("@dogru", correctAnswer);
                    using (SqlDataReader dr2 = yanlisCmd.ExecuteReader())
                    {
                        while (dr2.Read())
                            yanlisSecenekler.Add(dr2[0].ToString());
                    }
                }

                correctOptionIndex = rnd.Next(0, 4);
                yanlisSecenekler.Insert(correctOptionIndex, correctAnswer);

                FormsRadioButton[] secenekRadio = { radioButtonA, radioButtonB, radioButtonC, radioButtonD };
                for (int i = 0; i < 4; i++)
                {
                    secenekRadio[i].Text = yanlisSecenekler[i];
                    secenekRadio[i].Checked = false;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FormsRadioButton[] secenekRadio = { radioButtonA, radioButtonB, radioButtonC, radioButtonD };
            string secilen = secenekRadio.FirstOrDefault(r => r.Checked)?.Text;

            if (secilen == null)
            {
                MessageBox.Show("Lütfen bir seçenek işaretleyin.");
                return;
            }

            bool dogruMu = secilen == correctAnswer;

            labelDoğruluk.Text = dogruMu ? "Doğru!" : $"Yanlış! Doğru cevap: {correctAnswer}";
            labelDoğruluk.ForeColor = dogruMu ? Color.Green : Color.Red;
            QuizAdimiGuncelle(currentWordID, dogruMu);

            Task.Delay(2000).ContinueWith(_ =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    labelDoğruluk.Text = "";
                    aktifIndex++;
                    if (aktifIndex < quizKelimeleri.Count)
                    {
                        SoruYukle(quizKelimeleri[aktifIndex]);
                    }
                    else
                    {
                        MessageBox.Show("Tüm sorular tamamlandı.");
                        this.Close();
                    }
                });
            });
        }

        void QuizAdimiGuncelle(int wordID, bool dogru)
        {
            using (SqlConnection bagl = DBManager.BaglantiGetir(VeritabaniTipi.SozlukVocabulary))
            {
                if (bagl == null)
                {
                    MessageBox.Show("Kullanıcı veritabanına bağlanılamadı.");
                    return;
                }

                SqlCommand kontrolCmd = new SqlCommand("SELECT Derece FROM quiz_ilerleme WHERE WordID = @id AND userID = @user", bagl);
                kontrolCmd.Parameters.AddWithValue("@id", wordID);
                kontrolCmd.Parameters.AddWithValue("@user", Oturum.userID);

                object Derece = kontrolCmd.ExecuteScalar();

                if (Derece != null)
                {
                    int mevcutAdim = Convert.ToInt32(Derece);

                    if (dogru && mevcutAdim < 6)
                    {
                        SqlCommand guncelle = new SqlCommand("UPDATE quiz_ilerleme SET Derece = Derece + 1, SonDogruBilme = @tarih WHERE WordID = @id AND userID = @user", bagl);
                        guncelle.Parameters.AddWithValue("@tarih", DateTime.Now);
                        guncelle.Parameters.AddWithValue("@id", wordID);
                        guncelle.Parameters.AddWithValue("@user", Oturum.userID);
                        guncelle.ExecuteNonQuery();
                    }
                    else if (!dogru)
                    {
                        SqlCommand sifirla = new SqlCommand("UPDATE quiz_ilerleme SET Derece = 0 WHERE WordID = @id AND userID = @user", bagl);
                        sifirla.Parameters.AddWithValue("@id", wordID);
                        sifirla.Parameters.AddWithValue("@user", Oturum.userID);
                        sifirla.ExecuteNonQuery();
                    }
                }
                else
                {
                    SqlCommand ekle = new SqlCommand("INSERT INTO quiz_ilerleme (WordID, userID, Derece, SonDogruBilme) VALUES (@id, @userID, @Derece, @tarih)", bagl);
                    ekle.Parameters.AddWithValue("@id", wordID);
                    ekle.Parameters.AddWithValue("@userID", Oturum.userID);
                    ekle.Parameters.AddWithValue("@Derece", dogru ? 1 : 0);
                    ekle.Parameters.AddWithValue("@tarih", DateTime.Now);
                    ekle.ExecuteNonQuery();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}
