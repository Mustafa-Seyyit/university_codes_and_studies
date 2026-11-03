# Test tablosu

Tarih: 27 Ekim 2026. Sonuçlar `npm run test:e2e` çalışmasında üretilen `test-sonuclari.json` dosyasından alınmıştır.

| No | İşlem | Beklenen sonuç | Sonuç |
| --- | --- | --- | --- |
| T1 | Ana sayfadan Arıza Listesine git | Liste görünür. | ☑ Geçti |
| T2 | 101 numaralı arızada doğru başlık, konum, durum | 101 kaydının başlığı, Lab 2 konumu ve Bekliyor durumu görünür. | ☑ Geçti |
| T3 | Detaydan listeye dön ve ikinci kaydı aç | Liste tekrar açılır ve başka kayıt seçilebilir. | ☑ Geçti |
| T4 | Bilinmeyen /ariza/999 ve doğrudan girişte geri dönüş | Uyarı görünür, uygulama çökmez ve listeye dönülür. | ☑ Geçti |
| T5 | Stoksuz ürün p2 detayında Stokta yok görünür | Mekanik Klavye için Stokta yok ve 0 adet görünür. | ☑ Geçti |
| T6 | Ürün listesinden ikinci ürüne geç, doğru fiyat/açıklama | Seçilen ürünün doğru fiyat, stok ve açıklaması görünür. | ☑ Geçti |
| T7 | Dört dersin doğru gün, saat, sınıf, öğretim elemanı | Seçilen dersin doğru bilgileri görünür; dört kayıt ayrı ayrı açılır. | ☑ Geçti |

## Ek ekran testleri

| No | Doğrulanan davranış | Sonuç |
| --- | --- | --- |
| E1 | Arama ve filtre detaydan geri dönünce korunur | ☑ Geçti |
| E2 | Yeni Arıza: zorunlu alanlar ve Diğer kategori doğrulaması | ☑ Geçti |
| E3 | Acil talep onayı, vazgeçme ve tek kayıt ekleme | ☑ Geçti |
| E4 | Durum değişikliği, silme iptali ve onaylı silme | ☑ Geçti |
| E5 | Önceki haftanın form ve liste ekranları korunur | ☑ Geçti |
| E6 | Hatalı ürün ID ve geri dönüş | ☑ Geçti |
| E7 | Gün/arama filtresi, boş sonuç, sıfırlama | ☑ Geçti |
| E8 | Hatalı ders ID ve geri dönüş | ☑ Geçti |
| E9 | Sekmeler: görev tamamlama, yeniden açma, profil | ☑ Geçti |
| E10 | Tanımsız rota güvenli hata ekranı | ☑ Geçti |
| E11 | Dar telefon ve masaüstünde yatay taşma yok | ☑ Geçti |
| E12 | Tarayıcı çalışma zamanı hatası yok | ☑ Geçti |

## Kod ve paket kontrolleri

| Kontrol | Sonuç | Kanıt |
| --- | --- | --- |
| Önceki haftanın birim testleri | 18 / 18 geçti | Özgün klasörde çalıştırıldı; kaynak yedeği değişmedi |
| Yeni veri/form testleri | 22 / 22 geçti | `kod-kontrolu.log`, `tests/data.test.mjs` |
| ESLint | Geçti | `kod-kontrolu.log` |
| JavaScript/JSX tip kontrolü | Geçti | `tsc --noEmit`, `checkJs: true` |
| Expo SDK bağımlılık kontrolü | Geçti | Çevrim içi `expo install --check`: Dependencies are up to date |
| Dört uygulamanın Android paketleri | 4 / 4 oluştu | `paket-dogrulamasi.json` ve `build-*.log` |
| Dört uygulamanın iOS paketleri | 4 / 4 oluştu | Aynı kayıtlar |
| Dört uygulamanın web paketleri | 4 / 4 oluştu | Aynı kayıtlar ve 19 E2E testi |
| Tarayıcı çalışma zamanı hatası | 0 | `test-sonuclari.json` runtimeErrors |
| Özgün proje koruması | 36 dosya yedekle byte düzeyinde aynı | `paket-dogrulamasi.json` |

## Doğrulama kapsamı

Uygulama etkileşimleri Google Chrome üzerinde Expo'nun üretim web paketiyle test edildi. Telefon görünümü 390×844, dar ekran 320×900, masaüstü 1280×900 boyutunda denendi. Uzun form ve listelerin ekran görüntülerinde içerik kesilmesin diye 390 piksel genişlik korunarak yükseklik artırıldı; görüntüler emülatörden değil gerçek web uygulamasından alındı.

Android ve iOS için Metro/Hermes paketlemesi başarıyla tamamlandı. Fiziksel telefonda Expo Go veya Android/iOS emülatöründe çalışma testi yapılmadı; bu test yapılmış gibi işaretlenmedi. Föy web platformunu kabul ettiği için ekran akışları web ile doğrulandı.

Arıza ve görevler bellekte tutulur; yenileme/yeniden başlatma örnek verilere döner. Kalıcı depolama föyde zorunlu değildir. Kayıtlar ekran geçişlerinde korunur.
