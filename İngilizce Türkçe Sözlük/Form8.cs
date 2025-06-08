using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Deneme_Yanılma
{
    public partial class Form8 : Form
    {
        private void KodGonder(string aliciEmail, string kod)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("buolingodestek@gmail.com"); // Mail Adresimiz  
            mail.To.Add(aliciEmail);
            mail.Subject = "Şifre Sıfırlama Kodunuz";
            mail.Body = $"Kodunuz: {kod}";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("buolingodestek@gmail.com", "sbqhavesrlmqutxs"); // Gmail uygulama şifresi  

            smtp.Send(mail);
        }

        private Form previousForm;

        public Form8(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            pictureBox1.Click += pictureBox1_Click;
        }

        private void btnKodgonder_Click(object sender, EventArgs e)
        {
            string mail = TxtMail.Text.Trim();
            string Code = new Random().Next(100000, 999999).ToString();
            int userID;

            using (SqlConnection conn = new SqlConnection("Data Source=omer;Initial Catalog=kullanici_bilgi;Integrated Security=True;"))
            {
                conn.Open();

                SqlCommand getUser = new SqlCommand("SELECT userID FROM tbl_kullanici WHERE mail = @mail", conn);
                getUser.Parameters.AddWithValue("@mail", mail);
                object result = getUser.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Bu e-posta adresi kayıtlı değil.");
                    return;
                }

                userID = Convert.ToInt32(result);

                SqlCommand saveCode = new SqlCommand("SifreSifirlamaKodOlustur", conn);
                saveCode.CommandType = CommandType.StoredProcedure;
                saveCode.Parameters.AddWithValue("@userID", userID);
                saveCode.Parameters.AddWithValue("@Code", Code);
                saveCode.ExecuteNonQuery();

                conn.Close();

                KodGonder(mail, Code);
                MessageBox.Show("Kod e-posta adresinize gönderildi.");

                Form9 fr9 = new Form9(userID);
                fr9.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}
