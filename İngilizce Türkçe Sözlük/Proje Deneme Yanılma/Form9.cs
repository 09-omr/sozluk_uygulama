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
    public partial class Form9 : Form


    {
        private int userID;



        


        public Form9()
        {
            InitializeComponent();

        }

        private void Form9_Load(object sender, EventArgs e)
        {


        }

        public Form9(int userid)
        {
            InitializeComponent();
            userID = userid; 
        
        }


        private void btnDogrula_Click(object sender, EventArgs e)
        {


            string Code = TxtKod.Text.Trim();

            using (SqlConnection conn = new SqlConnection("Data Source=omer;Initial Catalog=kullanici_bilgi;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand("SifreSifirlamaKodDogrula", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@Code", Code);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Kod doğru. Şifre yenileme ekranına geçebilirsiniz.");
                    Form10 frm = new Form10(userID);
                    frm.Show();
                    this.Hide();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Kod geçersiz veya daha önce kullanılmış.");
                }
            }
        }
    }
}












    

