
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
    public partial class AdminGirisForm : Form
    {
        SqlConnection baglanti;
        SqlDataReader dr;
        SqlCommand komut;

        public AdminGirisForm()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = TxtKullaniciAdi.Text;
            string sifre = TxtSifre.Text;
            string departmanAdi = CmbDepartman.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(departmanAdi))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            baglanti = new SqlConnection("Data Source=YILDIZ;Initial Catalog=YildizPansiyon;Integrated Security=True");

            try
            {
                baglanti.Open();
                string query = "SELECT * FROM AdminGiris WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre AND departmanAdi = @departmanAdi";
                komut = new SqlCommand(query, baglanti);

                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", sifre);
                komut.Parameters.AddWithValue("@departmanAdi", departmanAdi);

                dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı", "YILDIZ PANSIYON", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (departmanAdi)
                    {
                        case "Muhasebe":
                            MuhasebeForm muhasebeForm = new MuhasebeForm();
                            muhasebeForm.Show();
                            break;
                        case "Resepsiyon":
                            ResepsiyonForm resepsiyonForm = new ResepsiyonForm();
                            resepsiyonForm.Show();
                            break;
                        case "Satın Alma":
                            SatinAlmaForm satinalmaForm = new SatinAlmaForm();
                            satinalmaForm.Show();
                            break;
                        default:
                            MessageBox.Show("Departman eşleşmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı, Şifre veya Departman Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
