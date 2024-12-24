using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace YildizPansiyon
{
    public partial class GelirGiderForm : Form
    {
        public GelirGiderForm()
        {
            InitializeComponent();
        }
        private void KasaTutariniGuncelle()
        {
            int sabitTutar = 9500;
            int toplamUcret = 0;

            using (SqlConnection baglanti = new SqlConnection("Data Source=YILDIZ;Initial Catalog=YildizPansiyon;Integrated Security=True"))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT SUM(ucret) FROM MusteriEkle", baglanti);
                object sonuc = komut.ExecuteScalar();

                if (sonuc != DBNull.Value)
                {
                    toplamUcret = Convert.ToInt32(sonuc);
                }
            }

            LblKasaTutar.Text = ((sabitTutar + toplamUcret) * 30).ToString();
        }

        private void FaturaTutariniGuncelle()
        {
            decimal toplamFaturaTutari = 0;

            using (SqlConnection baglanti = new SqlConnection("Data Source=YILDIZ;Initial Catalog=YildizPansiyon;Integrated Security=True"))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT SUM(toplamTutar) FROM faturalar", baglanti);
                object sonuc = komut.ExecuteScalar();

                if (sonuc != DBNull.Value)
                {
                    toplamFaturaTutari = Convert.ToDecimal(sonuc);
                }
            }

            LblFatura.Text = toplamFaturaTutari.ToString("N2");
        }
        private void ChartGuncelle()
        {
            chart1.Series.Clear();
            chart1.Series.Add("GelirGider");
            chart1.Series["GelirGider"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chart1.Series["GelirGider"].Points.AddXY("Kasa Tutarı", int.Parse(LblKasaTutar.Text));
            chart1.Series["GelirGider"].Points.AddXY("Personel Maaşları", int.Parse(LblPersonelMaas.Text));
            chart1.Series["GelirGider"].Points.AddXY("Faturalar", decimal.Parse(LblFatura.Text));

            chart1.Series["GelirGider"].IsValueShownAsLabel = true;
            chart1.Titles.Add("Gelir Gider Dağılımı");
            chart1.Series["GelirGider"]["PieLabelStyle"] = "Outside";
            chart1.Legends[0].Enabled = true;
        }

        private void GelirGiderForm_Load(object sender, EventArgs e)
        {
            KasaTutariniGuncelle();

            FaturaTutariniGuncelle();

            GeliriGuncelle();

            chart1.Series.Clear();

            chart1.Series.Add("GelirGider");
            chart1.Series["GelirGider"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // SQL bağlantısı
            string connectionString = "Data Source=YILDIZ;Initial Catalog=YildizPansiyon;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(connectionString);

            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("SELECT SUM(birimMaas * calisanSayisi) FROM birimler", baglanti);
                object sonuc = komut.ExecuteScalar();

                if (sonuc != DBNull.Value)
                {
                    LblPersonelMaas.Text = Convert.ToDecimal(sonuc).ToString("N2");
                }
                else
                {
                    LblPersonelMaas.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblPersonelMaas.Text = "0.00";
            }
            finally
            {
                baglanti.Close();
            }

            int kasaTutar = int.Parse(LblKasaTutar.Text);
            double personelMaas = double.Parse(LblPersonelMaas.Text);
            double faturaTutar = double.Parse(LblFatura.Text);

            chart1.Series["GelirGider"].Points.AddXY("Kasa Tutarı", kasaTutar);
            chart1.Series["GelirGider"].Points.AddXY("Personel Maaşları", personelMaas);
            chart1.Series["GelirGider"].Points.AddXY("Faturalar", faturaTutar);

            chart1.Series["GelirGider"].IsValueShownAsLabel = true;

            chart1.Titles.Add("Gelir Gider Dağılımı");

            chart1.Series["GelirGider"]["PieLabelStyle"] = "Outside";
            chart1.Legends[0].Enabled = true;
        }
        private void GeliriGuncelle()
        {
            try
            {
                int kasaTutar = int.Parse(LblKasaTutar.Text);
                int personelMaas = int.Parse(LblPersonelMaas.Text);
                decimal faturaTutar = decimal.Parse(LblFatura.Text);

                decimal toplamGelir = kasaTutar + personelMaas + faturaTutar;

                LblGelir.Text = toplamGelir.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gelir hesaplanırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblGelir.Text = "0.00";
            }
        }
    }
}
