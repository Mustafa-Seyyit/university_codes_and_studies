# Akıllı Arıza Talep Yönetimi — Hafta 5

Önceki haftanın **Teknik Destek / Arıza Bildirim** uygulaması geliştirilmiştir. Aynı Expo blank projesi, form doğrulaması, kategoriler, öncelikler ve acil müdahale onayı temel alınmıştır. Önceki sürümde yalnızca son talep görünürken bu sürümde tüm talepler listeye eklenir; ayrıntı, silme onayı ve durum yönetimi bulunur.

**Teknoloji:** Expo SDK 57, React Native, JavaScript ve JSX. Uygulama kaynaklarında TypeScript kullanılmaz; önceki projenin `tsconfig.json`, `.d.ts` dosyası ve doğrudan TypeScript geliştirme bağımlılıkları kaldırılmıştır. Form ve liste aynı uygulamada state ile seçilen iki görünüm olarak çalışır. Yeni navigasyon kütüphanesi eklenmemiştir.

## Bağımsız proje

Bu klasör tüm kaynakları, varlıkları, yapılandırmayı, testleri, raporu ve ekran görüntülerini içerir. Üst dizindeki veya komşu projelerdeki dosyalara ihtiyaç duymaz. Klasörü başka bir konuma taşıyıp içinden `npm ci` ve `npx expo start` çalıştırabilirsiniz. Bağımlılıklar kendi `node_modules` klasörüne kurulur.

## Kurulum ve çalıştırma

Node.js 22.13 veya üzeri gerekir.

```sh
cd hafta5_akilli_ariza_talep
npm install
npx expo start
```

Bu çalışma alanında bağımlılıklar kuruludur. Telefon ve bilgisayarı aynı ağa bağlayıp QR kodunu uyumlu Expo Go sürümüyle okutun. Bağlantı sorunu varsa `npx expo start --tunnel` kullanılabilir.

```sh
npm run web      # Tarayıcı önizlemesi
npm run android  # Android / kurulu emülatör
npm run ios      # iOS simülatörü; macOS ve Xcode gerekir
```

## Özellikler ve föy karşılığı

| Gereksinim | Uygulama davranışı |
| --- | --- |
| G1 | Başlık ve açıklama kontrollü `TextInput` alanlarında tutulur. Form/liste görünümü değişince taslak korunur. |
| G2 | Bilgisayar, Yazıcı, İnternet, Yazılım ve Diğer kategorileri seçilebilir; seçim yeni kayda aktarılır. |
| G3 | Boş veya boşluk içeren zorunlu alanlar reddedilir; hata penceresi ve alan altında açıklama gösterilir. |
| G4 | Geçerli kayıt benzersiz `TLP-` kimliğiyle listenin başına eklenir. Önceki kayıtlar korunur. Başarılı kayıttan sonra form temizlenir. |
| G5 | Kartın gövdesine kısa dokunma doğru talebin başlığını, açıklamasını, kategorisini, durumunu ve diğer bilgilerini açar. |
| G6 | Kartın gövdesine 600 ms uzun basma silme onayını açar. Vazgeç hiçbir kaydı değiştirmez; onay yalnızca seçilen kimliği siler. Çöp kutusu butonu aynı işlemin erişilebilir alternatifidir. |
| G7 | Detay penceresinde Bekliyor / İşlemde / Tamamlandı doğrudan seçilir. Tamamlanan kayıt yeniden Bekliyor yapılabilir. |
| G8 | Kayıt, hata, durum değişikliği, form temizleme ve silme için anlaşılır bildirimler gösterilir. |

**Önceki haftadan korunan kurallar:** Ad Soyad ve Birim zorunludur. Açıklama, başındaki/sonundaki boşluklar çıkarıldıktan sonra en az 10 karakter olmalıdır. Diğer kategorisi ek açıklama ister. Öncelik başlangıçta Orta, acil müdahale kapalıdır; acil talep kayıttan önce onay ister.

**Özgün özellik:** Yazdıkça başlık araması ve durum filtresi birlikte çalışır. Türkçe büyük/küçük harfler `toLocaleLowerCase('tr-TR')` ile ele alınır. Genel sayaçlar tüm kayıtları sayarken sonuç sayısı filtrelenmiş listeyi gösterir. Eşleşme yoksa filtreleri temizleme eylemi sunulur.

Yerleşim Flexbox kullanır. `flexDirection`, `flex`, `flexWrap`, `justifyContent`, `alignItems` ve `gap` ile farklı ekran genişlikleri desteklenir. Safe Area ve iOS klavye alanı dikkate alınır. Talep listesi `FlatList`, form ve uzun detaylar `ScrollView` ile kaydırılır.

## Veri kapsamı

Veriler yalnızca `useState` içinde tutulur; veritabanı, API veya oturum açma yoktur. Uygulama ilk açılışta boş listeyle başlar. Yeniden başlatıldığında/yenilendiğinde talepler silinir. Uygulama yüklendikten sonra kayıt, arama, filtre, durum değiştirme ve silme internet bağlantısına ihtiyaç duymaz.

Başarılı kayıttan sonra arama ve durum filtresi temizlenir; böylece yeni kayıt görünür olur. Aktif durum filtresindeki bir kaydın durumu değiştirilirse kayıt o listeden çıkabilir; silinmez. Detay penceresi kaydı tüm taleplerden kimliğiyle bulduğu için güncel durum görünmeye devam eder.

## Olay işleyicilerini bulma

| Dosya / fonksiyon | Görevi |
| --- | --- |
| `App.jsx` → `alanDegistir` | `onChangeText` / kategori / Switch olaylarını form state’ine aktarır. |
| `App.jsx` → `kaydetIstegi` | Doğrulamayı çalıştırır; hata veya acil onayı gösterir. |
| `App.jsx` → `talebiKaydet` | Kimlik üretir, yeni kaydı önceki listeye ekler, formu sıfırlar. |
| `App.jsx` → `detayAc` | Seçilen kayıt kimliğiyle detay penceresini açar. |
| `App.jsx` → `silmeIstegi` | Uzun basma veya sil butonundan sonra yalnızca onay penceresini açar. |
| `App.jsx` → `silmeyiOnayla` | Seçilen kimliği `filter()` ile listeden çıkarır. |
| `App.jsx` → `pencereyiKapat` | Onaydan vazgeçer; gerekiyorsa önceki ayrıntılara geri döner. |
| `App.jsx` → `durumDegistir` | Seçilen kaydı `map()` ile günceller. |
| `src/utils/talep.js` | Form doğrulama, kayıt hazırlama, kimlik, liste ve arama yardımcıları. |
| `src/components/TalepFormu.jsx` | Önceki formun yeniden kullanılabilir görünümü. |
| `src/components/TalepListesi.jsx` | `onPress`, `onLongPress`, arama, filtre ve liste kartları. |
| `src/components/TalepPenceresi.jsx` | Detay, silme, acil onayı ve hata pencereleri. |
| `src/components/Ortak.jsx` | Form alanı, seçenek, buton, durum rozeti ve bildirim bileşenleri. |

## Kontroller

```sh
npm run check              # ESLint + 18 JavaScript testi
npx expo install --check
npx expo-doctor
npm run export             # Android, iOS ve web paketleme
```

18 otomatik test; eski form doğrulamalarını, çoklu kayıt eklemeyi, aynı milisaniyede benzersiz kimlik üretimini, yalnızca hedef kaydı silmeyi, üç durum arasında geçişi, Türkçe aramayı, birleşik filtreyi ve sayaçları kapsar.

ESLint, Expo paket uyumluluğu ve `expo-doctor` kontrolünün 21/21 adımı başarılıdır. Android, iOS ve web üretim paketleri oluşturulmuştur.

Föydeki T1–T5 senaryoları ayrıca Chrome üzerinde etkileşimle doğrulanmıştır. 320 × 700, 390 × 844, 768 × 1024 ve yatay 844 × 390 boyutlarında liste ve modal kullanımı kontrol edilmiştir. Çevrimdışı durum değişikliği ve arama denenmiştir. Fiziksel Android/iOS cihaz testi yapılmamıştır; platform paketleme kontrolleri uygulanmıştır.

## Teslim dosyaları

[Test tablosu, özgün özellik açıklaması ve YZ kullanım kaydı](docs/HAFTA5_RAPOR.md).

En az üç ekran görüntüsü şartı için:

- [Form](screenshots/hafta5/02-talep-formu.png)
- [Talep listesi](screenshots/hafta5/03-talep-listesi.png)
- [Durum güncelleme sonucu](screenshots/hafta5/05-durum-guncelleme.png)
- [Silme onayı](screenshots/hafta5/04-silme-onayi.png)
- [Geçersiz kayıt uyarısı](screenshots/hafta5/01-hatali-kayit.png)
- [Birlikte çalışan arama ve filtre](screenshots/hafta5/06-arama-ve-filtre.png)
- [Tablet görünümü](screenshots/hafta5/07-tablet.png)

Görseller tarayıcıdaki test kayıtlarıyla alınmıştır. Kişisel taslaklar, üç olay akışı çizimi, öğrenci katkısı ve öz değerlendirme öğrenci tarafından eklenmelidir. GitHub deposu bu çalışma sırasında yayımlanmamıştır; raporda bağlantı için alan bırakılmıştır.

## Resmî belgeler

[Expo SDK 57](https://docs.expo.dev/versions/v57.0.0/), [Expo Safe Area](https://docs.expo.dev/versions/v57.0.0/sdk/safe-area-context/), [Pressable](https://reactnative.dev/docs/pressable), [Modal](https://reactnative.dev/docs/modal), [FlatList](https://reactnative.dev/docs/flatlist).
