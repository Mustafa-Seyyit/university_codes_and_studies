# Föy ile son sağlama

Kaynak: `KAYNAK_FOY.md`. Tarih: 27 Ekim 2026. Teknik gereksinimler, kaynak kodu ve çalıştırılan kontrollerle aşağıda eşleştirilmiştir. Öğrenciye özgü çalışma şartları ayrıca belirtilmiştir; bunlar otomasyonla tamamlanmış sayılmaz.

| Föy maddesi | Uygulama / kanıt | Son durum |
| --- | --- | --- |
| Önceki projenin çalışan kopyası ve ekranları koruma | `docs/hafta5_kaynak_yedegi.zip`; özgün 36 dosyanın yedekle byte karşılaştırması; 18 eski test; `/onceki-ekran` E5 | Tamam |
| JavaScript / JSX ve Expo Router | Dört uygulamanın `package.json` giriş noktası `expo-router/entry`; JSX ekranları | Tamam |
| Stack kurulumu | Zorunlu uygulamalarda `src/app/_layout.jsx` | Tamam |
| Arıza ana sayfa → liste | `ariza_takip/src/app/index.jsx` → `/arizalar`; T1 | Tamam |
| En az 3 arıza ve ortak veri | `ariza_takip/src/data/tickets.js`: 101, 102, 103 | Tamam |
| TicketCard: başlık, konum, durum | `src/components/TicketCard.jsx`; konum = birim | Tamam |
| Arıza listesi FlatList | `src/components/TalepListesi.jsx` | Tamam |
| ID ile `/ariza/[id]` ve useLocalSearchParams | `src/app/ariza/[id].jsx`; T2, T3 | Tamam |
| Detayda başlık, konum, durum, geri | Aynı ekran; T2, T3 | Tamam |
| StatusBadge: Bekliyor turuncu, İşlemde mavi, Çözüldü yeşil | `StatusBadge.jsx` ve `utils/talep.js`; üç durumun ekran görüntüleri | Tamam |
| Yeni Arıza navigasyonu ve mevcut formun korunması | `/yeni-ariza`; eski TalepFormu ve doğrulama; E2–E4 | Tamam |
| `/ariza/999` çökmemeli | Missing bileşeni; T4 | Tamam |
| Detay dönüşünde liste yeniden kullanılmalı | T3 ve E1, arama/durum filtresi de korunur | Tamam |
| Ayrı ürün projesi / çalışma klasörü | `apps/urun_katalogu`, bağımsız Expo yapılandırması | Tamam |
| En az 5 ürün, belirtilen alanlar | `src/data/products.js`: p1–p5; veri sözleşmesi testi | Tamam |
| Başlangıç p1/p2 verileri ve 3 ek ürün | Kablosuz Fare 450/8, Mekanik Klavye 1800/0, üç ek ürün | Tamam |
| ProductCard tek ürünü props ile almalı | `src/components/ProductCard.jsx` | Tamam |
| Ürün kartında ad, fiyat, kategori, stok | Liste ekran görüntüsü ve T5/T6 | Tamam |
| FlatList ve router.push | `src/app/index.jsx`, ProductCard | Tamam |
| `/urun/[id]`, useLocalSearchParams, ad/fiyat/açıklama/stok, geri | Dinamik detay; T5/T6 tüm beş ürünü açar | Tamam |
| Ürün bulunamadı ekranı | `/urun/999`, E6 | Tamam |
| Stok 0 = Stokta yok; diğer = Stokta | StockBadge; veri testi ve T5/T6 | Tamam |
| Tasarım kararı ve gerekçesi | `RAPOR.md` tasarım bölümü | Tamam |
| En az 4 ders: ID, ad, gün, saat, sınıf, öğretim elemanı | `ders_programi/src/data/courses.js`: d1–d4 | Tamam |
| CourseCard | `src/components/CourseCard.jsx` | Tamam |
| Dinamik ders detayı, tüm alanlar, geri | `/ders/[id]`; T7 dört dersi açar | Tamam |
| Hatalı ders ID | `/ders/999`, E8 | Tamam |
| Tercihe bağlı gün/ders filtresi | İki filtre, Türkçe arama, boş durum; E7 | Tamam |
| İsteğe bağlı ayrı Tabs projesi | `apps/gorev_takip`; Görevler, Tamamlananlar, Profil ayrı rota dosyaları | Tamam |
| Ortak görev kartı | TaskCard; tamamlama/yeniden açma ve profil E9 | Tamam |
| En az 2 yeniden kullanılabilir bileşen | Her uygulamada kart + ortak UI; arızada ayrıca rozet/form | Tamam |
| Ekran görüntüleri | `EKRAN_GORUNTULERI.md`, `ekranlar/` | Tamam |
| Test tablosu ve hata notu | `TEST_TABLOSU.md`, `RAPOR.md` H1/H2 | Tamam |
| 5–8 cümlelik kısa değerlendirme | `RAPOR.md`: 7 cümle | Tamam |
| 2–3 cümlelik AI kullanım açıklaması | `RAPOR.md`: 3 cümle ve gerçek katkı kapsamı | Tamam |
| Proje açılıyor ve Expo üzerinde çalışıyor | Expo web paketinde 19 E2E; 12 platform paketi; lint/tip/22 birim testi | Web doğrulandı; native paketler oluştu |
| Öğrencinin akışı/bileşen kararını kendisinin vermesi | AI tarafından önerilen kararlar raporda işaretli | Öğrencinin kişisel çalışması gerekli |
| En az bir hatayı öğrencinin kendi açıklamasıyla kaydetmesi | Gerçek teknik hata notu mevcut, AI yazarlığı açık | Öğrenci kendi açıklamasını eklemeli |
| Ad Soyad / Numara | Kullanıcı bu bilgileri vermedi | Öğrenci doldurmalı |

## Sağlama döngüsü

1. Kaynak incelendi, önceki projenin testleri geçti ve yedeği alındı.
2. Gereksinimler uygulandı; ilk tip kontrolünün ortaya çıkardığı isteğe bağlı props ve simge tipi sorunları düzeltildi.
3. Router bağımlılığı uyumsuzluğu Expo uyumlu kurulumla düzeltildi; tip, lint ve veri/form testleri geçti.
4. Gerçek tarayıcı akışlarında test seçicilerinin Stack/Tabs içinde arkada tutulan ekranları da seçtiği görüldü. Seçiciler görünür/erişilebilir ekranlarla sınırlandırıldı; 19 senaryonun tamamı geçti. Bu, uygulama hatası olarak kaydedilmedi.
5. Görsel incelemede ders listesi görüntüsünün son kartı kestiği görüldü; ekran görüntüsü tüm kartları içerecek uzunlukta yeniden alındı.
6. Paket dosyaları ve kaynak yedeği doğrulandı, test sonuçları ve teslim ZIP içeriği denetlendi.

Teknik gereksinimlerde bilinen açık eksik yoktur. Fiziksel cihaz/emülatör çalıştırma iddiası yoktur; web föyde izin verilen platformlardan biridir. Kişisel öğrenci şartları teknik doğrulama sonucundan ayrı tutulmuştur.
