# C# Otel-Otomasyonu
Proje İçeriği

Bu otel otomasyonu, aşağıdaki temel modüllerden oluşmaktadır:

1. Rezervasyon Modülü

Müşteriler için oda rezervasyonları yapabilir, giriş ve çıkış tarihlerini seçebilirsiniz.

Boş ve dolu odalar sistem üzerinden kolayca takip edilebilir.

Aynı gün içerisinde yapılan rezervasyonlar otomatik olarak 1 gece konaklama ücreti ile işlem görür.

2. Oda Takip Modülü

Tüm odaların doluluk durumu görsel olarak görüntülenir.

Dolu odalar kırmızı, boş odalar ise yeşil renk ile gösterilir.

Oda doluluğu değiştiğinde butonlar anında güncellenir.

3. Müşteri Kayıt Modülüe

Müşteri bilgileri kaydedilir (Ad, Soyad, TC Kimlik No, Telefon, E-Mail, vb.).

Müşteri kayıtlarına ilişkin detaylar görüntülenir ve güncellenebilir.

TC Kimlik No ve e-posta doğrulamaları sistem içinde otomatik olarak yapılır.

4. Faturalandırma Modülü

Konaklama sonunda otomatik olarak fatura oluşturulur.

Fatura tutarları müşteri kayıt bilgilerinden ve konaklama süresinden hesaplanır.

Faturalar PDF olarak kaydedilebilir ve basılabilir.

5. Gelir-Gider Takibi
   
Kasa durumu, müşteri ödemeleri ve personel maaşları otomatik olarak hesaba katılır.

Grafiksel (chart) görünüm ile gelir-gider dağılımı görüntülenir.

Personel maaşları, fatura toplamları ve stok güncelleme işlemleri yapılır.

6. Stok Yönetimi

Otel ihtiyaçları (yatak, havlu vb.) stok olarak takip edilir.

Minimum stok seviyeleri belirlenir ve tedarik işlemleri gerçekleştirilir.

Stok ekleme, silme ve güncelleme işlemleri yapılabilir.

Kullanım Talimatları

Projeyi indirin veya klonlayın:

git clone https://github.com/kullaniciAdi/OtelOtomasyon.git

Projeyi Visual Studio'da açın.

App.config dosyasındaki veritabanı bağlantı cümlesini kendi veritabanı bilgilerinize göre güncelleyin.

Projeyi derleyin ve çalıştırın.
