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
    public partial class Form10 : Form
    {       


        private int userID;
        public Form10(int uid)
        {
            InitializeComponent();
            userID = uid;
        }
        public Form10()
        {   
            InitializeComponent();
            
        }

        private void btnSifreonay_Click(object sender, EventArgs e)
        {
            string sifre1 = Txtyenisifre.Text.Trim();
            string sifre2 = Txtyenisifretekrar.Text.Trim();

            if (sifre1 != sifre2)
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source=omer;Initial Catalog=kullanici_bilgi;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand("SifreGuncelle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@YeniSifre", sifre1);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (string.IsNullOrWhiteSpace(Txtyenisifre.Text) ||
                    string.IsNullOrWhiteSpace(Txtyenisifretekrar.Text))

                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Şifreniz başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Form fr = new Form2();
                    fr.Show();
                }
            }
        }












        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void Txtyenisifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
