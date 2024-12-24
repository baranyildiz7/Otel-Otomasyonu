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
    public partial class FaturaForm : Form
    {
        public FaturaForm()
        {
            InitializeComponent();

        }

        private void FaturaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.Columns.Add("UrunAdi", "Ürün/Hizmet");
            dataGridView1.Columns.Add("Miktar", "Miktar");
            dataGridView1.Columns.Add("BirimFiyat", "Birim Fiyat");
            dataGridView1.Columns.Add("KDV", "KDV (%)");
            dataGridView1.Columns.Add("Toplam", "Toplam");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("", 1, 0.00, 18, 0.00);
        }

        private void Hesapla()
        {
            double araToplam = 0;
            double kdvToplam = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Miktar"].Value != null && row.Cells["BirimFiyat"].Value != null)
                {
                    double miktar = Convert.ToDouble(row.Cells["Miktar"].Value);
                    double birimFiyat = Convert.ToDouble(row.Cells["BirimFiyat"].Value);
                    double kdvOrani = Convert.ToDouble(row.Cells["KDV"].Value);

                    double toplam = miktar * birimFiyat;
                    double kdvTutari = toplam * kdvOrani / 100;

                    row.Cells["Toplam"].Value = toplam + kdvTutari;

                    araToplam += toplam;
                    kdvToplam += kdvTutari;
                }
            }

            lblAraToplam.Text = araToplam.ToString("C2");
            lblKdv.Text = kdvToplam.ToString("C2");
            lblGenelToplam.Text = (araToplam + kdvToplam).ToString("C2");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=YILDIZ;Initial Catalog=YildizPansiyon;Integrated Security=True"))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO faturalar (faturaNo, faturaTarihi, musteriAdi, toplamTutar) " +
                                   "VALUES (@faturaNo, @faturaTarihi, @musteriAdi, @toplamTutar)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@faturaNo", txtFaturaNo.Text);
                        komut.Parameters.AddWithValue("@faturaTarihi", dtpFaturaTarihi.Value);
                        komut.Parameters.AddWithValue("@musteriAdi", cmbMusteri.Text);
                        komut.Parameters.AddWithValue("@toplamTutar", Convert.ToDecimal(lblGenelToplam.Text.Replace("₺", "")));

                        komut.ExecuteNonQuery();
                        MessageBox.Show("Fatura başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormuTemizle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormuTemizle()
        {
            txtFaturaNo.Clear();
            txtVergiDairesi.Clear();
            txtVergiNo.Clear();
            mskdTxtTelefon.Clear();
            cmbMusteri.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
            lblAraToplam.Text = "0.00 ₺";
            lblKdv.Text = "0.00 ₺";
            lblGenelToplam.Text = "0.00 ₺";
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Hesapla();
        }
    }
}
