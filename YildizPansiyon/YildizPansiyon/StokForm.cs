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
    public partial class StokForm : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=YILDIZ;Initial Catalog=YildizPansiyon;Integrated Security=True");
        public StokForm()
        {
            InitializeComponent();
        }

        void StokListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Stoklar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Combobox içeriğini güncelle
            CmbID.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                CmbID.Items.Add(row["stokID"].ToString());
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(
                "INSERT INTO Stoklar (urunAdi, kategori, miktar, birim, minStok, tedarikci, tedarikTarihi, aciklama) " +
                "VALUES (@urunAdi, @kategori, @miktar, @birim, @minStok, @tedarikci, @tedarikTarihi, @aciklama); " +
                "SELECT SCOPE_IDENTITY()", baglanti);

            komut.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@kategori", cmbKategori.Text);
            komut.Parameters.AddWithValue("@miktar", int.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@birim", cmbBirim.Text);
            komut.Parameters.AddWithValue("@minStok", int.Parse(txtMinStok.Text));
            komut.Parameters.AddWithValue("@tedarikci", txtTedarikci.Text);
            komut.Parameters.AddWithValue("@tedarikTarihi", dtpTedarikTarihi.Value);
            komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);

            // Eklenen kaydın ID'sini al
            int yeniID = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            MessageBox.Show("Stok Eklendi!");

            // Combobox'a yeni eklenen ID'yi ekle
            CmbID.Items.Add(yeniID.ToString());
            StokListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(
                "UPDATE Stoklar SET urunAdi=@urunAdi, kategori=@kategori, miktar=@miktar, birim=@birim, minStok=@minStok, " +
                "tedarikci=@tedarikci, tedarikTarihi=@tedarikTarihi, aciklama=@aciklama WHERE stokID=@id", baglanti);

            komut.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@kategori", cmbKategori.Text);
            komut.Parameters.AddWithValue("@miktar", int.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@birim", cmbBirim.Text);
            komut.Parameters.AddWithValue("@minStok", int.Parse(txtMinStok.Text));
            komut.Parameters.AddWithValue("@tedarikci", txtTedarikci.Text);
            komut.Parameters.AddWithValue("@tedarikTarihi", dtpTedarikTarihi.Value);
            komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            komut.Parameters.AddWithValue("@id", CmbID.Text);  // Comboboxtan seçilen ID

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Stok Güncellendi!");
            StokListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Stoklar WHERE stokID=@id", baglanti);
            komut.Parameters.AddWithValue("@id", CmbID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Stok Silindi!");
            StokListele();
        }

        private void StokForm_Load(object sender, EventArgs e)
        {
            StokListele();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.Columns["stokID"].HeaderText = "ID";
            dataGridView1.Columns["urunAdi"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["kategori"].HeaderText = "Kategori";
            dataGridView1.Columns["miktar"].HeaderText = "Miktar";
            dataGridView1.Columns["birim"].HeaderText = "Birim";
            dataGridView1.Columns["minStok"].HeaderText = "Min. Stok";
            dataGridView1.Columns["tedarikci"].HeaderText = "Tedarikçi";
            dataGridView1.Columns["tedarikTarihi"].HeaderText = "Tedarik Tarihi";
            dataGridView1.Columns["aciklama"].HeaderText = "Açıklama";
        }
    }
}
