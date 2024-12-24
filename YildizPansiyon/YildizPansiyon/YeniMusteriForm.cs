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
using YildizPansiyon.Properties;

namespace YildizPansiyon
{
    public partial class YeniMusteriForm : Form
    {
        public YeniMusteriForm()
        {
            InitializeComponent();
        }

        YildizPansiyonEntities ype = new YildizPansiyonEntities();
    
        private void BtnOda101_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.odaNo = 101;

            OdayaEKleForm frm = new OdayaEKleForm();
            frm.Show();
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.odaNo = 102;

            OdayaEKleForm frm = new OdayaEKleForm();
            frm.Show();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.odaNo = 103;

            OdayaEKleForm frm = new OdayaEKleForm();
            frm.Show();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.odaNo = 104;

            OdayaEKleForm frm = new OdayaEKleForm();
            frm.Show();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.odaNo = 105;

            OdayaEKleForm frm = new OdayaEKleForm();
            frm.Show();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.odaNo = 106;

            OdayaEKleForm frm = new OdayaEKleForm();
            frm.Show();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.odaNo = 107;

            OdayaEKleForm frm = new OdayaEKleForm();
            frm.Show();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.odaNo = 108;

            OdayaEKleForm frm = new OdayaEKleForm();
            frm.Show();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.odaNo = 109;

            OdayaEKleForm frm = new OdayaEKleForm();
            frm.Show();
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime GirisTarihi = dtpGirisTarihi.Value;
            DateTime CikisTarihi = dtpCikisTarihi.Value;

            TimeSpan sonuc = CikisTarihi - GirisTarihi;

            int gunSayisi = (int)sonuc.TotalDays + 1;

            ucret = gunSayisi * 400;

            LblUcret.Text = gunSayisi.ToString();
            TxtUcret.Text = ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // TC Kimlik No Doğrulama
            if (!TcKimlikDogrula(TxtTC.Text))
            {
                MessageBox.Show("Geçersiz TC Kimlik Numarası!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // E-Mail Doğrulama
            if (!MailDogrula(TxtMail.Text))
            {
                MessageBox.Show("Geçersiz e-posta adresi! Lütfen doğru formatta e-posta girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yeni müşteri kaydetme kodları burada olacak
            MusteriEkle yeniMusteri = new MusteriEkle();

            yeniMusteri.musteriAdi = TxtAdi.Text;
            yeniMusteri.musteriSoyadi = TxtSoyadi.Text;
            yeniMusteri.musteriCinsiyet = CmbBoxCinsiyet.Text;
            yeniMusteri.musteriTelefon = mskdTxtTelefon.Text;
            yeniMusteri.musteriMail = TxtMail.Text;
            yeniMusteri.musteriTC = TxtTC.Text;
            yeniMusteri.ucret = int.Parse(TxtUcret.Text);
            yeniMusteri.girisTarihi = dtpGirisTarihi.Value;
            yeniMusteri.cikisTarihi = dtpCikisTarihi.Value;

            // Oda numarasını al
            int odaNumarasi = Properties.Settings.Default.odaNo;

            // Musteri'yi eklerken oda bilgisini ata
            var secilenOda = ype.odalar.FirstOrDefault(o => o.odaNo == odaNumarasi);
            if (secilenOda != null)
            {
                yeniMusteri.odaID = secilenOda.odaID;
                secilenOda.musteriID = yeniMusteri.musteriID;
            }

            // Müşteri kaydedildiğinde
            ype.MusteriEkle.Add(yeniMusteri);
            if (ype.SaveChanges() > 0)
            {
                MessageBox.Show("Müşteri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt sırasında hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OdaDurumunuGuncelle()
        {
            foreach (odalar oda in ype.odalar.ToList())
            {
                Button btnOda = this.Controls.Find("BtnOda" + oda.odaNo, true).FirstOrDefault() as Button;

                if (btnOda != null)
                {
                    if (oda.musteriID != null)
                    {
                        btnOda.BackColor = Color.Red;
                        btnOda.Enabled = false;
                    }
                    else
                    {
                        btnOda.BackColor = Color.Lime;
                        btnOda.Enabled = true;
                    }
                }
            }
        }

        private void YeniMusteriForm_Load(object sender, EventArgs e)
        {

            OdaDurumunuGuncelle();
        
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtUcret.Text))
            {
                MessageBox.Show("Ödeme tutarı girilmemiş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // OdemeForm örneği oluştur
            OdemeForm odemeForm = new OdemeForm();

            // TxtUcret'te yazan değeri OdemeForm'a taşı
            odemeForm.Tutar = TxtUcret.Text;

            // OdemeForm'u göster
            odemeForm.ShowDialog();
        }

        private bool TcKimlikDogrula(string tc)
        {
            if (tc.Length != 11) return false;
            if (!tc.All(char.IsDigit)) return false;  // Sadece rakam olmalı
            if (tc[0] == '0') return false;  // İlk hanesi 0 olamaz

            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam += int.Parse(tc[i].ToString());
            }

            // Son hanesi çift olmalı
            if (toplam % 10 != int.Parse(tc[10].ToString())) return false;

            return true;
        }

        private bool MailDogrula(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;

            // E-Mail regex kontrolü
            string desen = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov|edu|mil)$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, desen);
        }
    }
}
