using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace YildizPansiyon
{
    public partial class MusterilerForm : Form
    {
        public MusterilerForm()
        {
            InitializeComponent();
        }

        YildizPansiyonEntities ype = new YildizPansiyonEntities();

        // Verileri Göster
        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            var sonuc = (from musteri in ype.MusteriEkle
                         join oda in ype.odalar on musteri.odaID equals oda.odaID into odaBilgileri
                         from oda in odaBilgileri.DefaultIfEmpty()
                         select new
                         {
                             musteri.musteriAdi,
                             musteri.musteriSoyadi,
                             musteri.musteriCinsiyet,
                             musteri.musteriTelefon,
                             musteri.musteriMail,
                             musteri.musteriTC,
                             odaNo = (int?)oda.odaNo,// Nullable yapıldı
                             musteri.ucret,
                             musteri.girisTarihi,
                             musteri.cikisTarihi
                         }).ToList();

            dataGridView1.DataSource = sonuc;

            // Sütun Başlıklarını Düzenleme
            dataGridView1.Columns["musteriAdi"].HeaderText = "Ad";
            dataGridView1.Columns["musteriSoyadi"].HeaderText = "Soyad";
            dataGridView1.Columns["musteriCinsiyet"].HeaderText = "Cinsiyet";
            dataGridView1.Columns["musteriTelefon"].HeaderText = "Telefon";
            dataGridView1.Columns["musteriMail"].HeaderText = "Email";
            dataGridView1.Columns["musteriTC"].HeaderText = "TC_No";
            dataGridView1.Columns["odaNo"].HeaderText = "Oda_No";
            dataGridView1.Columns["ucret"].HeaderText = "Ücret";
            dataGridView1.Columns["girisTarihi"].HeaderText = "Giriş_Tarihi";
            dataGridView1.Columns["cikisTarihi"].HeaderText = "Çıkış_Tarihi";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
        }

        // Güncelleme İşlemi (TC'ye Göre)
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string tcNo = TxtAra.Text.Trim();
            var guncellenecek = ype.MusteriEkle.FirstOrDefault(x => x.musteriTC == tcNo);

            if (guncellenecek != null)
            {
                // Güncellenen müşteri bilgileri
                guncellenecek.musteriAdi = TxtAdi.Text;
                guncellenecek.musteriSoyadi = TxtSoyadi.Text;
                guncellenecek.musteriCinsiyet = CmbBoxCinsiyet.Text;
                guncellenecek.musteriTelefon = mskdTxtTelefon.Text;
                guncellenecek.musteriMail = TxtMail.Text;
                guncellenecek.ucret = int.Parse(TxtUcret.Text);
                guncellenecek.girisTarihi = dtpGirisTarihi.Value;
                guncellenecek.cikisTarihi = dtpCikisTarihi.Value;

                // Oda güncelleme işlemi
                int yeniOdaNo = int.Parse(TxtOdaNo.Text);  // Yeni oda numarası
                var yeniOda = ype.odalar.FirstOrDefault(x => x.odaNo == yeniOdaNo);
                var eskiOda = ype.odalar.FirstOrDefault(x => x.odaID == guncellenecek.odaID);

                // Oda dolu mu kontrol et
                if (yeniOda != null && yeniOda.musteriID != null && yeniOda.musteriID != guncellenecek.musteriID)
                {
                    MessageBox.Show("Bu oda dolu! Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Eski oda boşaltılıyor
                if (eskiOda != null)
                {
                    eskiOda.musteriID = null;
                }

                // Yeni oda atanıyor
                if (yeniOda != null)
                {
                    yeniOda.musteriID = guncellenecek.musteriID;
                    guncellenecek.odaID = yeniOda.odaID;
                }

                // Veritabanı değişikliklerini kaydet
                if (ype.SaveChanges() > 0)
                {
                    MessageBox.Show("Müşteri ve oda bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnVerileriGoster_Click(sender, e);

                    // YeniMusteriForm'daki oda durumlarını güncelle
                    YeniMusteriForm yeniMusteriForm = Application.OpenForms.OfType<YeniMusteriForm>().FirstOrDefault();
                    if (yeniMusteriForm != null)
                    {
                        yeniMusteriForm.OdaDurumunuGuncelle();
                    }
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik Numarasına ait müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Silme İşlemi (TC'ye Göre)
        private void BtnSil_Click(object sender, EventArgs e)
        {
            string tcNo = TxtAra.Text.Trim();
            var musteri = ype.MusteriEkle.FirstOrDefault(x => x.musteriTC == tcNo);

            if (musteri != null)
            {
                // Müşterinin bağlı olduğu odayı bul
                var bosaltilacakOda = ype.odalar.FirstOrDefault(x => x.musteriID == musteri.musteriID);

                if (bosaltilacakOda != null)
                {
                    bosaltilacakOda.musteriID = null;  // Odayı boşalt
                    musteri.odaID = null;  // Müşterinin oda bilgisini temizle

                    // Odayı yeşil yap ve aktif hale getir
                    Button btnOda = this.Controls.Find("BtnOda" + bosaltilacakOda.odaNo, true).FirstOrDefault() as Button;

                    if (btnOda != null)
                    {
                        btnOda.BackColor = Color.Lime;  // Odayı yeşile çevir
                        btnOda.Enabled = true;  // Odayı tekrar seçilebilir yap
                    }
                }

                if (ype.SaveChanges() > 0)
                {
                    MessageBox.Show("Oda boşaltıldı, müşteri kaydı silinmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnVerileriGoster_Click(sender, e);  // Datagridview güncellemesi
                }
                else
                {
                    MessageBox.Show("Oda boşaltma işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik Numarasına ait müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Listeleme (Arama Kutusu)
        private void TxtAra_TextChanged(object sender, EventArgs e)
        {
            var musteri = (from m in ype.MusteriEkle
                           join oda in ype.odalar on m.odaID equals oda.odaID into odaBilgileri
                           from oda in odaBilgileri.DefaultIfEmpty()
                           where m.musteriTC == TxtAra.Text.Trim()
                           select new
                           {
                               m.musteriAdi,
                               m.musteriSoyadi,
                               m.musteriCinsiyet,
                               m.musteriTelefon,
                               m.musteriMail,
                               m.musteriTC,
                               odaNo = (int?)oda.odaNo,  // Nullable Oda No
                               m.ucret,
                               m.girisTarihi,
                               m.cikisTarihi
                           }).FirstOrDefault();

            if (musteri != null)
            {
                TxtAdi.Text = musteri.musteriAdi;
                TxtSoyadi.Text = musteri.musteriSoyadi;
                CmbBoxCinsiyet.Text = musteri.musteriCinsiyet;
                mskdTxtTelefon.Text = musteri.musteriTelefon;
                TxtMail.Text = musteri.musteriMail;
                TxtTC.Text = musteri.musteriTC;
                TxtUcret.Text = musteri.ucret.ToString();
                dtpGirisTarihi.Value = musteri.girisTarihi;
                dtpCikisTarihi.Value = musteri.cikisTarihi;

                // Oda No'yu TextBox'a yazdır
                TxtOdaNo.Text = musteri.odaNo.HasValue ? musteri.odaNo.ToString() : "Odası Yok";
            }
            else
            {
                Temizle();
            }
        }

        // Temizleme İşlemi
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CmbBoxCinsiyet.SelectedIndex = -1;
            mskdTxtTelefon.Clear();
            TxtMail.Clear();
            TxtTC.Clear();
            TxtUcret.Clear();
            TxtOdaNo.Clear();
            dtpGirisTarihi.Value = DateTime.Now;
            dtpCikisTarihi.Value = DateTime.Now;
            TxtAra.Clear();
        }

        // Form Yüklendiğinde Çalışacak Kod
        private void MusterilerForm_Load(object sender, EventArgs e)
        {
            

            // DateTimePicker olaylarını bağla
            dtpGirisTarihi.ValueChanged += TarihDegisti;
            dtpCikisTarihi.ValueChanged += TarihDegisti;

            // İlk açılışta tarih değişikliklerini tetikle
            TarihDegisti(null, null);
        }

        // Alanları temizlemek için metod
        private void Temizle()
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CmbBoxCinsiyet.SelectedIndex = -1;
            mskdTxtTelefon.Clear();
            TxtMail.Clear();
            TxtTC.Clear();
            TxtUcret.Clear();
            dtpGirisTarihi.Value = DateTime.Now;
            dtpCikisTarihi.Value = DateTime.Now;
        }

        private void TarihDegisti(object sender, EventArgs e)
        {
            // Giriş ve çıkış tarihlerini al
            DateTime GirisTarihi = dtpGirisTarihi.Value;
            DateTime CikisTarihi = dtpCikisTarihi.Value;

            // Tarih farkını hesapla
            TimeSpan sonuc = CikisTarihi - GirisTarihi;

            // Gün farkını hesapla (her durumda minimum 1 gün)
            int gunSayisi = (int)sonuc.TotalDays + 1;

            // Ücret hesaplama (400 TL günlük ücret)
            int ucret = gunSayisi * 400;

            // Label ve TextBox'ları güncelle
            LblUcret.Text = gunSayisi.ToString();
            TxtUcret.Text = ucret.ToString();
        }
    }
}
