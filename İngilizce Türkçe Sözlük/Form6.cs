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
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;



namespace Proje_Deneme_Yanılma
{
    public partial class Form6 : Form
    {
        string selectedImagePath = "";
        private Form previousForm;

        public Form6(Form previous)
        {
            InitializeComponent();
            previousForm = previous;
        }


        // Resim ekleme butonuna tıklandığında çalışır.
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları| *.jgp;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK) {

                selectedImagePath = ofd.FileName;
                pictureBoxResim.Image = Image.FromFile(selectedImagePath);
            }
        }
        // Kelime ekleme butonuna tıklandığında çalışır.
        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEnglish.Text) || string.IsNullOrWhiteSpace(TxtTürkçe.Text)
        || string.IsNullOrEmpty(selectedImagePath) || string.IsNullOrWhiteSpace(comboBoxTip.Text)
        || string.IsNullOrWhiteSpace(TxtllkHarf.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz ve bir resim seçiniz.");
                return;
            }

            try
            {
                byte[] imageBytes = File.ReadAllBytes(selectedImagePath);

                using (SqlConnection bagl = DBManager.BaglantiGetir(VeritabaniTipi.SozlukVocabulary))
                {
                    if (bagl == null)
                    {
                        MessageBox.Show("Veritabanına bağlanılamadı.");
                        return;
                    }

                    string query = "INSERT INTO vocabulary_clean_for_sql (Section, en, tr, Type, image) VALUES (@Section, @en, @tr, @Type, @image)";
                    SqlCommand cmd = new SqlCommand(query, bagl);

                    // Parametre isimlerini sorguyla aynı yaptım (büyük/küçük harfe dikkat)
                    cmd.Parameters.AddWithValue("@Section", TxtllkHarf.Text.Trim());
                    cmd.Parameters.AddWithValue("@en", TxtEnglish.Text.Trim());
                    cmd.Parameters.AddWithValue("@tr", TxtTürkçe.Text.Trim());
                    cmd.Parameters.AddWithValue("@Type", comboBoxTip.Text.Trim());
                    cmd.Parameters.AddWithValue("@image", imageBytes);

                    cmd.ExecuteNonQuery();

                    SqlCommand getIdCmd = new SqlCommand("SELECT SCOPE_IDENTITY()", bagl);
                    object result = getIdCmd.ExecuteScalar();

                    

                    

                    MessageBox.Show("Kelime başarıyla eklendi.");

                    TxtEnglish.Clear();
                    TxtTürkçe.Clear();
                    
                    pictureBoxResim.Image = null;
                    selectedImagePath = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        // Form yüklendiğinde pictureBox2'ye tıklama olayını ekler.
        private void KelimeEkle_Load(object sender, EventArgs e)
        {
            pictureBoxKapat.Click += pictureBox2_Click;
        }
        // pictureBoxKapat'ye tıklandığında önceki forma geri döner.
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
            }
        
    

