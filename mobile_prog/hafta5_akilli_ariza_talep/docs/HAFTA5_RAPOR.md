# Hafta 5 — Uygulama ve Test Raporu

**Proje:** Akıllı Arıza Talep Yönetimi  
**Teknoloji:** Expo + React Native, JavaScript/JSX  
**Kontrol tarihi:** 20 Ekim 2026  
**Öğrenci / numara:** [Öğrenci dolduracak]  
**GitHub bağlantısı:** [Henüz yayımlanmadı; depo bağlantısını ekleyin]

Bu raporun teknik uygulama ve test bölümleri yapay zekâ desteğiyle hazırlanmıştır. Öğrenciye ait kişisel çizim, katkı veya deneyim iddiası içermez.

## Önceki haftadan bu haftaya

Önceki sürüm, formdan yalnızca son oluşturulan talebi özet kartında gösteriyordu. Yeni sürümde `sonTalep` yerine `talepler` dizisi kullanıldı; yeni kayıt önceki kayıtları silmeden listenin başına ekleniyor. Formun kategori, Diğer alanı, öncelik, karakter sayacı ve acil talep onayı korunuyor. Yeni kayıt durumu bu föyün istediği `Bekliyor` olarak değiştirildi. Listeye dokunma, uzun basma, silme onayı ve doğrudan durum seçimi eklendi.

## Test senaryoları ve sonuçlar

Kontroller üretim web paketi üzerinde Chrome ile otomatik kullanıcı etkileşimleri kullanılarak yapıldı. Gerçek Android/iOS cihazında test yapılmadı.

| Senaryo | Beklenen sonuç | Gerçek sonuç |
| --- | --- | --- |
| T1 — Başlık boşlukken Kaydet | Kayıt eklenmez; hata mesajı gösterilir. | **Geçti.** Eksik Bilgi penceresi açıldı; açıklama ve diğer girişler korundu, liste 0 kaldı. |
| T1 ek — Açıklama boşlukken Kaydet | Kayıt eklenmez. | **Geçti.** Geçersiz Açıklama penceresi açıldı. |
| T2 — Geçerli talep ekle | Benzersiz kimlikli tek kayıt oluşur. | **Geçti.** İlk kayıt 1 olarak listelendi; sonraki iki ekleme ile 3 farklı kimlikli kayıt korundu. Hızlı çift tıklama ilk kaydı çoğaltmadı. |
| T3 — Uzun bas → Vazgeç | Talep silinmez. | **Geçti.** 600 ms eşiğini aşan basma silme onayını açtı; Vazgeç sonrası 3 kayıt da korundu. Kısa dokunma detayı ayrıca açılmadı. |
| T4 — Durumu değiştir | Yalnızca seçilen talep güncellenir. | **Geçti.** Bilgisayar talebi Tamamlandı → Bekliyor → İşlemde olarak değiştirildi; diğer iki talep Bekliyor kaldı. |
| T5 — Özgün özellik | Başlık araması ve durum filtresi birlikte çalışır. | **Geçti.** `internet` araması `İNTERNET bağlantısı kesildi` kaydını buldu. İşlemde filtresiyle sonuç 0 oldu; filtreleri temizleyince 3 kayıt döndü. |
| Silmeyi onayla | Yalnızca seçilen kayıt silinir. | **Geçti.** Yazıcı talebi silindi; bilgisayar ve internet talepleri korundu. |
| Form/liste arasında geçiş | Taslak korunur. | **Geçti.** Yazılmış başlık ve açıklama geri dönüldüğünde duruyordu. |
| Aktif filtrede durum değiştir | Kayıt yeni durumu nedeniyle listeden çıkabilir, detay güncel kalır. | **Geçti.** İşlemde filtresindeki kayıt tamamlanınca sonuç 0 oldu; detayda Tamamlandı seçimi ve genel sayaç güncellendi. |
| Diğer / acil talep | Eksik tür reddedilir; acil onayını iptal etmek kayıt eklemez. | **Geçti.** Diğer türü doğrulandı; Vazgeç taslağı korudu, Onayla ve kaydet tek acil kayıt oluşturdu. |
| Çevrimdışı | Yüklü uygulamanın yerel eylemleri çalışır. | **Geçti.** Tarayıcı çevrimdışı durumdayken kayıt durumu güncellendi ve başlık araması yapıldı. |
| Yeniden yükleme | Yerel state sıfırlanır. | **Geçti.** Boş liste gösterildi. |

18 JavaScript birim testi de başarılıdır. Küçük ekran, telefon, tablet ve yatay görünüm için 320 × 700, 390 × 844, 768 × 1024, 844 × 390 boyutlarında taşma ve modal etkileşimleri kontrol edilmiştir.

**Görsel kanıt:** [form](../screenshots/hafta5/02-talep-formu.png), [liste](../screenshots/hafta5/03-talep-listesi.png), [durum değişikliği](../screenshots/hafta5/05-durum-guncelleme.png), [silme onayı](../screenshots/hafta5/04-silme-onayi.png).

## Hata / eksiklik / iyileştirme notu

**Öncesi:** Yeni talep oluşturmak önceki son-talep özetini değiştiriyordu; kullanıcı birden fazla kaydı yönetemiyordu. **Sonrası:** Fonksiyonel `setTalepler` ve yeni dizi oluşturma yaklaşımıyla tüm kayıtlar korunuyor, değişiklik ve silme kimlik üzerinden uygulanıyor. Ayrıca hızlı çift kayıt için koruma eklendi; aynı milisaniyedeki kimliklerin çakışması engellendi. Uyumluluk kontrolü mevcut Expo 57.0.28 sürümü için 57.0.30 yamasını istedi; proje bu yama sürümüne güncellendi. Bu maddeler geliştirme sırasında gerçekten yapılan değişikliklerdir.

## Özgün özelliğin açıklaması — 5 cümle

Talep sayısı arttıkça belirli bir arızayı listede bulmak zorlaştığı için canlı başlık araması ve durum filtresi eklendi. Kullanıcının arama alanına yazması `onChangeText` üzerinden `arama`, durum seçmesi ise `onPress` üzerinden `durumFiltresi` state’ini değiştirir. `src/utils/talep.js` içindeki `talepleriFiltrele`, iki koşulu birlikte uygulayarak kaynak kayıtları değiştirmeden yeni bir görünür liste üretir. `App.jsx` hesaplamayı, `src/components/TalepListesi.jsx` arama alanını, filtreleri ve sonuç sayısını yönetir. Türkçe büyük/küçük harfler, birlikte filtreleme, boş sonuç ve filtreleri temizleme senaryoları test edilip başarılı bulunmuştur.

## Yapay zekâ kullanım kaydı

Aşağıdaki iki istek bu konuşmadan alınmıştır; öğrenci tarafından sonradan yapılmış işlemler gibi sunulmamıştır.

**Prompt 1 — Hafta 5 geliştirmesi**

> daha önce geliştİdirdiğimiz arıza tespit çalışması önceki haftanın çalışmasıdır buna göre ekde verdiğim projeyi geliştir.

Ek teknoloji isteği: Expo + React Native ve JavaScript kullanılması, TypeScript kullanılmaması.

**Yanıt / çalışma özeti:** Föy ve mevcut uygulama incelendi. Önceki JavaScript formu çoklu talep listesi, detay, silme onayı, üç durum seçimi, arama ve filtre ile genişletildi. Kod ve tarayıcı testleri çalıştırıldı; ekran görüntüleri alındı.

**Prompt 2 — Önceki çalışma sırasında Flexbox açıklaması**

> bu uygulamada hangi flexbox özelliklerini kullandın kısa bir metin yaz

**Yanıt özeti:** `flexDirection`, `justifyContent`, `alignItems`, `flex`, `flexWrap`, `gap`, `flexGrow`, `flexShrink` ve `flexBasis` özelliklerinin önceki paneldeki kullanımı açıklandı. Bu istek kod üretmekten çok yerleşimi anlamaya yönelikti.

**Öğrencinin bizzat yaptığı değişiklikler:** [Öğrenci dolduracak. Yalnızca kendinizin gerçekleştirdiği değişiklikleri ve incelediğiniz handler’ları yazın.]

## Öğrencinin tamamlayacağı kişisel bölümler

Föy B bölümündeki çizimler öğrenci tarafından hazırlanmalıdır; burada yapay zekâ üretimi bir çizim eklenmemiştir.

- Form taslağı: [Kendi çiziminizin fotoğrafı / dosya yolu]
- Talep listesi veya detay taslağı: [Kendi çiziminizin fotoğrafı / dosya yolu]
- Başarılı kayıt olay akışı: [Kendi çiziminiz]
- Geçersiz kayıt olay akışı: [Kendi çiziminiz]
- Uzun basma ile silme olay akışı: [Kendi çiziminiz]
- Kişisel tasarım kararınız ve gerekçesi: [Öğrenci dolduracak]

## Kişisel öz değerlendirme

- En çok zorlandığınız olay ve nedeni: [Öğrenci dolduracak]
- Yapay zekânın yardımcı olduğu nokta: [Öğrenci dolduracak]
- Kendi verdiğiniz en önemli tasarım kararı: [Öğrenci dolduracak]
- Yeniden geliştirseydiniz değiştireceğiniz etkileşim: [Öğrenci dolduracak]
