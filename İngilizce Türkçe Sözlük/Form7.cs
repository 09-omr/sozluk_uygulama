using Proje_Deneme_Yanılma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsRadioButton = System.Windows.Forms.RadioButton; // Ambiguity çözümü

namespace Proje_Deneme_Yanilma
{
    


    public partial class Form7 : Form
    {
        private void Form7_Load(object sender, EventArgs e)
        {
            labelDoğruluk.Visible = false;
        }


        // Kelime quiz formu
        List<int> quizKelimeleri = new List<int>();
        int aktifIndex = 0;
        Random rnd = new Random();
        string correctAnswer = "";
        int correctOptionIndex = -1;
        int currentWordID = -1;
        private Form previousForm;
        private int dogruSayisi = 0;
        private int yanlisSayisi = 0;

        

        public Form7(Form prevForm)
        {
            InitializeComponent();
            previousForm = prevForm; //form3 referansını alıyoruz.
        }

        
        private void Quiz_Load(object sender, EventArgs e)
        {   // Form yüklendiğinde çalışacak kodlarımız.
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

            int defaultKelimeSayisi = 10; // Default soru sayısı
            int ekstraKelimeSayisi = Ayarlar.YeniKelimeSayisi; // Ayarlardan gelen ekstra soru sayısı

            int toplamKelimeSayisi = defaultKelimeSayisi + ekstraKelimeSayisi;

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

            List<int> zamanliKelimeler = new List<int>();

            using (SqlConnection bagl = DBManager.BaglantiGetir(VeritabaniTipi.SozlukVocabulary))
            {
                if (bagl == null)
                {
                    MessageBox.Show("Kullanıcı veritabanına bağlanılamadı.");
                    return;
                }

                // Zamanı gelen kelimeleri çek
                SqlCommand zamanCmd = new SqlCommand("SELECT WordID, Derece, SonDogruBilme FROM quiz_ilerleme WHERE userID = @user", bagl);
                zamanCmd.Parameters.AddWithValue("@user", aktifKullaniciId);

                using (SqlDataReader dr = zamanCmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int derece = Convert.ToInt32(dr["Derece"]);
                        object tarihObj = dr["SonDogruBilme"];
                        int WordID = Convert.ToInt32(dr["WordID"]);

                        if (tarihObj != DBNull.Value)
                        {
                            DateTime sonDogru = Convert.ToDateTime(tarihObj);
                            if (derece >= 1 && derece <= 6 && DateTime.Now >= sonDogru.Add(zamanlar[derece]))
                            {
                                zamanliKelimeler.Add(WordID);
                            }
                        }
                    }
                }

                // Zamanlı kelimeleri quiz listesine ekle
                quizKelimeleri.AddRange(zamanliKelimeler);

                // Gerekli sayıda yeni kelime alalım: toplamKelimeSayisi - zamanliKelimeler.Count
                int eksikKelimeSayisi = toplamKelimeSayisi - quizKelimeleri.Count;
                if (eksikKelimeSayisi > 0)
                {
                    SqlCommand yeniKelimeCmd = new SqlCommand(@"
                SELECT TOP (@sayi) WordID FROM dbo.vocabulary_clean_for_sql
                WHERE WordID NOT IN (
                    SELECT WordID FROM quiz_ilerleme WHERE userID = @user
                ) ORDER BY NEWID()", bagl);

                    yeniKelimeCmd.Parameters.AddWithValue("@user", aktifKullaniciId);
                    yeniKelimeCmd.Parameters.AddWithValue("@sayi", eksikKelimeSayisi);

                    using (SqlDataReader drYeni = yeniKelimeCmd.ExecuteReader())
                    {
                        while (drYeni.Read())
                        {
                            int WordID = Convert.ToInt32(drYeni["WordID"]);
                            quizKelimeleri.Add(WordID);
                        }
                    }
                }
            }

            // Soruları karıştır
            quizKelimeleri = quizKelimeleri.OrderBy(x => Guid.NewGuid()).ToList();

            if (quizKelimeleri.Count > 0)
            {
                SoruYukle(quizKelimeleri[0]);
            }
            else
            {
                MessageBox.Show("Zamanı gelmiş veya yeni eklenecek kelime bulunamadı.");
            }
        }
        // Bu metot, veritabanından kelimeyi yükler ve soruyu hazırlar.
        void SoruYukle(int WordID)
        {   //DBManager sınıfındaki bağlantı ile sozluk_vocabulary veritabanına bağlanıyoruz.
            using (SqlConnection bagl = DBManager.BaglantiGetir(VeritabaniTipi.SozlukVocabulary))
            {
                if (bagl == null)
                {
                    MessageBox.Show("Sözlük veritabanına bağlanılamadı.");
                    return;
                }
                // Veritabanından kelime bilgilerini çekiyoruz.
                SqlCommand cmd = new SqlCommand("SELECT WordID, en, tr, image FROM dbo.vocabulary_clean_for_sql WHERE WordID = @id", bagl);
                cmd.Parameters.AddWithValue("@id", WordID);

                string en = null;
                string tr = null;
                currentWordID = -1;

                // verilen WordID'ye ait kelime bilgilerini alıyoruz.
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        en = dr["en"].ToString();
                        tr = dr["tr"].ToString();

                        // Görsel varsa göster
                        if (dr["image"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])dr["image"];
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pictureBoxSoru.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBoxSoru.Image = null; // görsel yoksa temizle
                        }

                        currentWordID = Convert.ToInt32(dr["WordID"]);
                        dr.Close();

                        SqlCommand cumleCmd = new SqlCommand("SELECT TOP 1 Samples FROM cumle_tutma WHERE ID = @id", bagl);
                        cumleCmd.Parameters.AddWithValue("@id", currentWordID);
                        object cumleObj = cumleCmd.ExecuteScalar();

                        if (cumleObj != null)
                        {
                            labelCumle.Text = "Örnek Cümle:\n" + cumleObj.ToString();
                        }
                        else
                        {
                            labelCumle.Text = "Bu kelime için örnek cümle bulunamadı.";
                        }


                    }
                    else
                    {
                        MessageBox.Show("Kelime bulunamadı.");
                        return;
                    }
                }

                bool ingilizceSorulsunMu = rnd.Next(0, 2) == 0;
                // Bu satır, rastgele olarak İngilizce veya Türkçe sorulup sorulmayacağını belirler.
                correctAnswer = ingilizceSorulsunMu ? tr : en;

                labelsoru.Text = ingilizceSorulsunMu
                    ? $"Bu İngilizce kelimenin Türkçe karşılığı nedir?\n→ {en}"
                    : $"Bu Türkçe kelimenin İngilizcesi nedir?\n→ {tr}";


                // Yanlış seçenekleri hazırlıyoruz.
                List<string> yanlisSecenekler = new List<string>();

                using (SqlCommand yanlisCmd = new SqlCommand(
                    ingilizceSorulsunMu
                        ? "SELECT TOP 3 tr FROM dbo.vocabulary_clean_for_sql WHERE tr != @dogru ORDER BY NEWID()"
                        : "SELECT TOP 3 en FROM dbo.vocabulary_clean_for_sql WHERE en != @dogru ORDER BY NEWID()",
                    bagl))
                {   // Bu sorgu, doğru cevabı hariç tutarak rastgele 3 yanlış seçenek seçecek.
                    yanlisCmd.Parameters.AddWithValue("@dogru", correctAnswer);

                    using (SqlDataReader dr2 = yanlisCmd.ExecuteReader())
                    {   // Yanlış seçenekleri okuyup listeye ekliyoruz.
                        while (dr2.Read())
                        {
                            yanlisSecenekler.Add(dr2[0].ToString());
                        }
                    }
                }
                // Doğru cevabı rastgele bir yere yerleştiriyoruz.
                correctOptionIndex = rnd.Next(0, 4);
                yanlisSecenekler.Insert(correctOptionIndex, correctAnswer);
                // Seçenekleri radio butonlarına atıyoruz.
                FormsRadioButton[] secenekRadio = { radioButtonA, radioButtonB, radioButtonC, radioButtonD };
                for (int i = 0; i < 4; i++)
                {
                    secenekRadio[i].Text = yanlisSecenekler[i];
                    secenekRadio[i].Checked = false;
                }
            }
        }



        // Bu metot, "Sonraki" butonuna tıklandığında soru boş ise onu kontrol eder veya doğru,yanlış durumunu bildirerek sonraki sorumuza geçer.
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
            labelDoğruluk.Visible = true;

            QuizAdimiGuncelle(currentWordID, dogruMu);
            if (dogruMu)
                dogruSayisi++;
            else
                yanlisSayisi++;

            Task.Delay(2000).ContinueWith(_ =>
            {// 2 saniye bekledikten sonra sonraki soruya geçiyoruz.
                this.Invoke((MethodInvoker)delegate
                {
                    labelDoğruluk.Visible = false;
                    labelDoğruluk.Text = "";
                    aktifIndex++;
                    if (aktifIndex < quizKelimeleri.Count)
                    {   // Eğer daha fazla soru varsa, yeni soruyu yüklüyoruz.
                        SoruYukle(quizKelimeleri[aktifIndex]);
                    }
                    else
                    {
                        /*if (dogruMu)
                            dogruSayisi++;
                        else
                            yanlisSayisi++;*/
                        Ayarlar.YeniKelimeSayisi = 0;

                        MessageBox.Show($"Tüm sorular tamamlandı.\nDoğru: {dogruSayisi}\nYanlış: {yanlisSayisi}",
        "Quiz Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (previousForm != null && !previousForm.IsDisposed)
                        {
                            previousForm.Show();
                        }

                        this.Close();
                    }
                });
            });
        }

        void QuizAdimiGuncelle(int wordID, bool dogru)
        {   // Bu metot, kullanıcının quiz ilerlemesini günceller.
            using (SqlConnection bagl = DBManager.BaglantiGetir(VeritabaniTipi.SozlukVocabulary))
            {
                if (bagl == null)
                {
                    MessageBox.Show("Kullanıcı veritabanına bağlanılamadı.");
                    return;
                }
                // Veritabanında kullanıcının ilerlemesini kontrol ediyoruz.
                SqlCommand kontrolCmd = new SqlCommand("SELECT Derece FROM quiz_ilerleme WHERE WordID = @id AND userID = @user", bagl);
                kontrolCmd.Parameters.AddWithValue("@id", wordID);
                kontrolCmd.Parameters.AddWithValue("@user", Oturum.userID);
                // Bu sorgu, kullanıcının bu kelime için ilerleme derecesini kontrol eder.
                object Derece = kontrolCmd.ExecuteScalar();
                
                if (Derece != null)
                {   // Eğer kullanıcı bu kelime için ilerleme kaydetmişse, Derece değişkeni null olmayacaktır.
                    int mevcutAdim = Convert.ToInt32(Derece);
                    
                    if (dogru && mevcutAdim < 6)
                    {   // Eğer doğru cevap verdiyse ve derecesi 6'dan küçükse, derecesini artırıyoruz.
                        SqlCommand guncelle = new SqlCommand("UPDATE quiz_ilerleme SET Derece = Derece + 1, SonDogruBilme = @tarih WHERE WordID = @id AND userID = @user", bagl);
                        guncelle.Parameters.AddWithValue("@tarih", DateTime.Now);
                        guncelle.Parameters.AddWithValue("@id", wordID);
                        guncelle.Parameters.AddWithValue("@user", Oturum.userID);
                        guncelle.ExecuteNonQuery();
                    }
                    else if (!dogru)
                    {   // Eğer yanlış cevap verdiyse, derecesini sıfırlıyoruz.
                        SqlCommand sifirla = new SqlCommand("UPDATE quiz_ilerleme SET Derece = 0 WHERE WordID = @id AND userID = @user", bagl);
                        sifirla.Parameters.AddWithValue("@id", wordID);
                        sifirla.Parameters.AddWithValue("@user", Oturum.userID);
                        sifirla.ExecuteNonQuery();
                    }
                }
                else
                {   // Eğer kullanıcı bu kelime için ilerleme kaydetmemişse, yeni bir kayıt ekliyoruz.
                    SqlCommand ekle = new SqlCommand("INSERT INTO quiz_ilerleme (WordID, userID, Derece, SonDogruBilme) VALUES (@id, @userID, @Derece, @tarih)", bagl);
                    ekle.Parameters.AddWithValue("@id", wordID);
                    ekle.Parameters.AddWithValue("@userID", Oturum.userID);
                    ekle.Parameters.AddWithValue("@Derece", dogru ? 1 : 0);
                    ekle.Parameters.AddWithValue("@tarih", DateTime.Now);
                    ekle.ExecuteNonQuery();
                }
                SqlCommand kontrolProgressCmd = new SqlCommand("SELECT ProgressID, CorrectCount, IncorrectCount FROM UserWordProgress WHERE UserID = @user AND WordID = @word", bagl);
                kontrolProgressCmd.Parameters.AddWithValue("@user", Oturum.userID);
                kontrolProgressCmd.Parameters.AddWithValue("@word", wordID);

                using (SqlDataReader dr = kontrolProgressCmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        // Kayıt var ise güncelle
                        int progressID = Convert.ToInt32(dr["ProgressID"]);
                        int correctCount = Convert.ToInt32(dr["CorrectCount"]);
                        int incorrectCount = Convert.ToInt32(dr["IncorrectCount"]);
                        dr.Close(); // Reader kapatılmalı ki UPDATE yapılabilsin

                        if (dogru)
                        {
                            correctCount++;
                        }
                        else
                        {
                            incorrectCount++;
                        }

                        SqlCommand updateProgressCmd = new SqlCommand("UPDATE UserWordProgress SET CorrectCount = @correct, IncorrectCount = @incorrect WHERE ProgressID = @progressID", bagl);
                        updateProgressCmd.Parameters.AddWithValue("@correct", correctCount);
                        updateProgressCmd.Parameters.AddWithValue("@incorrect", incorrectCount);
                        updateProgressCmd.Parameters.AddWithValue("@progressID", progressID);
                        updateProgressCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        dr.Close();

                        // Kayıt yok ise yeni ekle
                        SqlCommand insertProgressCmd = new SqlCommand("INSERT INTO UserWordProgress (UserID, WordID, CorrectCount, IncorrectCount) VALUES (@user, @word, @correct, @incorrect)", bagl);
                        insertProgressCmd.Parameters.AddWithValue("@user", Oturum.userID);
                        insertProgressCmd.Parameters.AddWithValue("@word", wordID);
                        insertProgressCmd.Parameters.AddWithValue("@correct", dogru ? 1 : 0);
                        insertProgressCmd.Parameters.AddWithValue("@incorrect", dogru ? 0 : 1);
                        insertProgressCmd.ExecuteNonQuery();
                    }
                }
            }

        }
        
        // Bu metot, geri butonuna tıklandığında önceki forma geri döner.
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void pictureBoxSoru_Click(object sender, EventArgs e)
        {

        }
    }
}
