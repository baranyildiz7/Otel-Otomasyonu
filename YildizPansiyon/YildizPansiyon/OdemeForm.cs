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

namespace YildizPansiyon
{
    public partial class OdemeForm : Form
    {

        // Tutarı taşımak için bir property tanımla
        public string Tutar
        {
            get { return LblTutar.Text; }
            set { LblTutar.Text = value; }
        }

        public OdemeForm()
        {
            InitializeComponent();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {

            // CVV kontrolü (3 hane)
            if (txtCvv.Text.Length != 3)
            {
                MessageBox.Show("CVV kodu 3 haneli olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kart son kullanma tarihi kontrolü
            if (int.Parse(txtYil.Text) < DateTime.Now.Year ||
                (int.Parse(txtYil.Text) == DateTime.Now.Year && int.Parse(txtAy.Text) < DateTime.Now.Month))
            {
                MessageBox.Show("Kartın son kullanma tarihi geçmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kart numarası formatı (MaskedTextBox için)
            txtKartNo.Mask = "0000 0000 0000 0000";

            // Veritabanı bağlantısı
            using (SqlConnection baglanti = new SqlConnection("Data Source=YILDIZ;Initial Catalog=YildizPansiyon;Integrated Security=True"))
            {
                try
                {
                    baglanti.Open();

                    // SQL Sorgusu
                    string sorgu = "INSERT INTO odemeler (adSoyad, kartNo, sktAy, sktYil, cvv, tutar) " +
                                   "VALUES (@adSoyad, @kartNo, @sktAy, @sktYil, @cvv, @tutar)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        // Parametreler
                        komut.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@kartNo", txtKartNo.Text);
                        komut.Parameters.AddWithValue("@sktAy", txtAy.Text);
                        komut.Parameters.AddWithValue("@sktYil", txtYil.Text);
                        komut.Parameters.AddWithValue("@cvv", txtCvv.Text);
                        komut.Parameters.AddWithValue("@tutar", int.Parse(LblTutar.Text));  // Tutarı ekle

                        int sonuc = komut.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Ödeme başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormuTemizle();
                        }
                        else
                        {
                            MessageBox.Show("Ödeme kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void FormuTemizle()
        {
            txtAdSoyad.Clear();
            txtKartNo.Clear();
            txtAy.Clear();
            txtYil.Clear();
            txtCvv.Clear();
        }
    }
}
