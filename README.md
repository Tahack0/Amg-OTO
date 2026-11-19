# AMG Oto Servis Otomasyonu

C# Windows Forms ve MySQL ile araç, müşteri, servis ve ödeme kayıtlarını yönetir.

1. MySQL 8’de `schema.sql` dosyasını boş bir veritabanına uygula.
2. Yerel bağlantı dizesini `AMG_OTO_CONNECTION_STRING` ortam değişkeninde ayarla.
3. Visual Studio’da `Amg-OTO/Amg-OTO.slnx` dosyasını aç ve NuGet paketlerini geri yükle. Proje .NET Framework 4.7.2 hedefler.
4. Yerel deneme için `adminler` tablosunda kendine ait bir test hesabı oluştur. Orijinal uygulamanın giriş modeli parolaları düz metin olarak karşılaştırır.
