using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Proje_Deneme_Yanılma
{
    public partial class Form13 : Form


    {   




        private Form previousForm;

        public Form13(Form previous)
        {
            InitializeComponent();
            previousForm = previous;
        }



        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            GrafikYukle();
            chart1.Visible = true;
            chart1.BringToFront();
        }


        private void GrafikYukle()
        {
            using (SqlConnection conn = DBManager.BaglantiGetir(VeritabaniTipi.SozlukVocabulary))
            {
                if (conn == null)
                {
                    MessageBox.Show("Veritabanı bağlantısı başarısız.");
                    return;
                }

                SqlCommand cmd = new SqlCommand(@"
                SELECT 
                    v.Type AS Kategori,
                    SUM(uwp.CorrectCount) AS DogruSayisi,
                    SUM(uwp.IncorrectCount) AS YanlisSayisi,
                    CAST(SUM(uwp.CorrectCount) * 100.0 / 
                         NULLIF(SUM(uwp.CorrectCount + uwp.IncorrectCount), 0) AS DECIMAL(5,2)) AS BasariYuzdesi
                FROM UserWordProgress uwp
                JOIN vocabulary_clean_for_sql v ON uwp.WordID = v.WordID
                WHERE uwp.UserID = @userID
                GROUP BY v.Type", conn);

                cmd.Parameters.AddWithValue("@userID", Oturum.userID);

                SqlDataReader dr = cmd.ExecuteReader();

                chart1.Series.Clear();
                Series s = chart1.Series.Add("Başarı Yüzdesi");
                s.ChartType = SeriesChartType.Pie;
                s.Color = Color.SteelBlue;
                //chart1.ChartAreas[0].AxisY.Maximum = 100;
                chart1.ChartAreas[0].AxisY.Title = "%";
                bool veriVarMi = false;
                while (dr.Read())
                {
                    double yuzde = Convert.ToDouble(dr["BasariYuzdesi"]);
                    if (yuzde <= 0) continue; // 0 veya negatif başarı varsa atla

                    veriVarMi = true;
                    string kategori = dr["Kategori"].ToString();
                    s.Points.AddXY(kategori, yuzde);
                }

                if (!veriVarMi)
                    MessageBox.Show("Bu kullanıcıya ait analiz verisi bulunamadı.");
            }
        }



        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                Bitmap bmp = new Bitmap(chart1.Width, chart1.Height);
                chart1.DrawToBitmap(bmp, chart1.ClientRectangle);
                ev.Graphics.DrawImage(bmp, 50, 50);
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (previousForm != null && !previousForm.IsDisposed)
            {
                previousForm.Show();
            }
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
