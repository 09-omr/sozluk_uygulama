using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proje_Deneme_Yanılma
{
    public enum VeritabaniTipi
    {
        KullaniciBilgi,
        SozlukVocabulary
    }

    internal class DBManager
    {
        public static SqlConnection BaglantiGetir(VeritabaniTipi tip)
        {
            string connectionString = "";

            switch (tip)
            {   //Giriş yapma,kayıt olma, şifre sıfırlama işlemleri için kullanıcı bilgilerini tutan veritabanı.
                case VeritabaniTipi.KullaniciBilgi:
                    connectionString = "Data Source=omer;Initial Catalog=kullanici_bilgi;Integrated Security=True;TrustServerCertificate=True";
                    break;
                //Kelime ekleme, silme, güncelleme işlemleri için kelimeleri tutan veritabanı.
                case VeritabaniTipi.SozlukVocabulary:
                    connectionString = "Data Source=omer;Initial Catalog=sozluk_vocabulary;Integrated Security=True;TrustServerCertificate=True";
                    break;

                default:
                    MessageBox.Show("Bilinmeyen veritabanı tipi.");
                    return null;
            }

            try
            {
                SqlConnection baglanti = new SqlConnection(connectionString);
                baglanti.Open();
                
                return baglanti;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}

