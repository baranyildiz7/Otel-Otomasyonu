🏨 Otel Otomasyonu Projesi
Bu proje, bir otel otomasyonu sistemi geliştirmek için tasarlanmıştır. Proje, otel işleyişini kolaylaştırmak ve müşteri kayıt, oda takibi, fatura yönetimi gibi temel işlemleri dijital ortama taşımak amacıyla geliştirilmiştir.

🔧 Proje Özellikleri

- Oda Rezervasyon Sistemi: Oda ekleme, güncelleme ve silme işlemleri.

- Müşteri Kayıt Sistemi: Müşteri kaydı, oda ataması ve müşteri çıkışı.

- Fatura Yönetimi: Müşterilere ait fatura oluşturma ve tutar hesaplama.

- Gelir-Gider Takibi: Personel maaşları, fatura tutarları ve kasa toplamının izlenmesi.

- Stok Takibi: Otel için gerekli stokların eklenmesi, güncellenmesi ve silinmesi.

- Kasa Yönetimi: Otel kasasında biriken gelirlerin takip edilmesi ve güncellenmesi.

- Yetkilendirme: Muhasebe, resepsiyon ve satın alma departmanları için ayrı yetkilendirme sistemleri.

👨‍💼 Admin Paneli

- Adminler, müşteri kayıtlarını ve oda durumlarını takip edebilir.

- Tüm departmanların giriş ve çıkışları admin tarafından kontrol edilebilir.

- Fatura ve gelir-gider dengeleri admin panelinden izlenebilir.

👩‍💼 Kullanıcı Rolleri

- Muhasebe: Fatura ve gelir-gider işlemlerini yönetir.

- Resepsiyon: Müşteri kayıtlarını ve oda atamalarını yapar.

- Satın Alma: Otel için stok ekleme, güncelleme ve sipariş işlemlerini gerçekleştirir.

🛠️ Kurulum

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

# Projeyi klonlayın
git clone https://github.com/kullaniciAdi/otel-otomasyonu.git

# Proje dizinine gidin
cd otel-otomasyonu

# Visual Studio ile projeyi açın ve derleyin

📊 Veri Tabanı

Projede Microsoft SQL Server kullanılmaktadır. Veritabanı yapısı aşağıdaki gibidir:

- adminGiris (kullanıcı seçenekleri)

- birimler (departmanalar ve maaşları)
  
- musteriEkle (müşteri kayıtları)

- odalar (oda bilgileri ve durumları)

- faturalar (fatura işlemleri)

- stoklar (otel stokları)

- odemeler (ödenecek tutar)

- musteriMesaj (müşterilerin talepleri)

👍 Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için LICENSE dosyasına bakın.
