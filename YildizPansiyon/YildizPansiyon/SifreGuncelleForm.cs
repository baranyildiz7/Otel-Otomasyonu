using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YildizPansiyon
{
    public partial class SifreGuncelleForm : Form
    {

        private string veritabaniKullaniciAdi;
        private string veritabaniSifre;

        public SifreGuncelleForm()
        {
            InitializeComponent();
        }

        YildizPansiyonEntities ype = new YildizPansiyonEntities();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDepartman = cmbDepartman.SelectedItem?.ToString();

            // Veritabanında seçilen departmana göre kullanıcı adı ve şifreyi çek
            AdminGiris listelenecek = ype.AdminGiris
                .Where(x => x.departmanAdi == secilenDepartman)
                .FirstOrDefault();

            if (listelenecek != null)
            {
                // Kullanıcı adı ve şifreyi arka planda tut (textbox'a yazma)
                veritabaniKullaniciAdi = listelenecek.kullaniciAdi;
                veritabaniSifre = listelenecek.sifre;
            }
            else
            {
                // Kullanıcı bulunamazsa değişkenleri temizle
                veritabaniKullaniciAdi = string.Empty;
                veritabaniSifre = string.Empty;
            }
        }

        private void SifreGuncelleForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string secilenDepartman = cmbDepartman.SelectedItem?.ToString();
            string girilenKullaniciAdi = txtKullaniciAdi.Text.Trim();
            string girilenEskiSifre = txtEskiSifre.Text.Trim();
            string yeniSifre = txtYeniSifre.Text.Trim();

            // Alanlar boşsa uyarı ver
            if (string.IsNullOrEmpty(secilenDepartman) || string.IsNullOrEmpty(girilenKullaniciAdi) ||
                string.IsNullOrEmpty(girilenEskiSifre) || string.IsNullOrEmpty(yeniSifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı adı ve şifre doğrulama
            if (girilenKullaniciAdi == veritabaniKullaniciAdi && girilenEskiSifre == veritabaniSifre)
            {
                // Kullanıcı doğrulandı, şifre güncelleniyor
                AdminGiris guncellenecek = ype.AdminGiris
                    .Where(x => x.departmanAdi == secilenDepartman)
                    .FirstOrDefault();

                if (guncellenecek != null)
                {
                    guncellenecek.sifre = yeniSifre;

                    if (ype.SaveChanges() > 0)
                    {
                        MessageBox.Show("Şifre başarıyla güncellendi.", "YILDIZ PANSIYON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Şifre güncellenirken hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya eski şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Temizle()
        {
            txtKullaniciAdi.Clear();
            txtEskiSifre.Clear();
            txtYeniSifre.Clear();
            cmbDepartman.SelectedIndex = -1;
            veritabaniKullaniciAdi = string.Empty;
            veritabaniSifre = string.Empty;
        }
    }
}
