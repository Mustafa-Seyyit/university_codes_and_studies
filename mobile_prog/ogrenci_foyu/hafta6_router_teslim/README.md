# Expo Router — 27 Ekim 2026 uygulama teslimi

Föydeki üç zorunlu uygulama ve isteğe bağlı sekmeli görev uygulaması, ayrı Expo proje klasörlerinde hazırlanmıştır. Kod JavaScript/JSX'tir. Arıza uygulaması önceki haftanın projesinin çalışan kopyası üzerine kurulmuştur; özgün klasörler korunmuştur.

## Başlatma

Node.js 24 ve npm 11 ile doğrulandı. İlk kurulum paket indirmek için internet ister; uygulama verileri yereldir ve kullanım sırasında internet/veritabanı gerekmez.

```sh
cd /Users/.../Desktop/mobil_prog/ogrenci_foyu/hafta6_router_teslim
npm ci
npm run ariza
```

Terminalde `w` web, `a` Android, `i` iOS seçeneğini açar. Expo Go için ekrandaki QR kodunu tarayın; cihaz ile bilgisayar aynı ağda olmalıdır. Android/iOS emülatörü kullanılacaksa önceden kurulu olmalıdır.

| Proje                 | Komut           | Web komutu          | Geliştirme portu |
| --------------------- | --------------- | ------------------- | ---------------- |
| Arıza Takip           | `npm run ariza` | `npm run ariza:web` | 8081             |
| Mini Ürün Kataloğu    | `npm run urun`  | `npm run urun:web`  | 8082             |
| Öğrenci Ders Programı | `npm run ders`  | `npm run ders:web`  | 8083             |
| Sekmeli Görev Takip   | `npm run gorev` | `npm run gorev:web` | 8084             |

Kök dizindeki npm workspaces yalnızca bağımlılık kurulumunu ortaklaştırır. Her uygulamanın kendi `package.json`, `app.json`, `src/app` ve bileşen/veri dosyaları vardır. Bir uygulama klasörü tek başına başka konuma kopyalanarak `npm install` ve `npm start` ile de çalıştırılabilir.

## Kontroller

```sh
npm run check       # Lint + JSX tip kontrolü + 22 veri/form testi
npm run export      # Dört proje için Android, iOS, web paketleri
npm run test:e2e    # Kurulu Google Chrome ile gerçek web ekran akışları ve görüntüler
```

E2E testi önce `npm run export` çalıştırılmasını bekler. `tests/e2e.mjs`, önizleme sunucularını 8091–8094 portlarında açıp test sonunda kapatır. Google Chrome yoksa Playwright Chromium kurulumu sonrasında `PLAYWRIGHT_CHANNEL=chromium npm run test:e2e` kullanılabilir.

Yalnızca paketlenmiş web sürümlerini incelemek için:

```sh
node tests/serve.mjs
```

Ardından [Arıza](http://127.0.0.1:8091), [Ürün](http://127.0.0.1:8092), [Ders](http://127.0.0.1:8093), [Görev](http://127.0.0.1:8094) önizlemelerini açın. Sunucuyu Ctrl+C ile kapatın. `dist` klasörleri dağıtım ZIP'ine dahil değildir; export komutu üretir.

## Dosyalar

- [Öncelikli plan](docs/PLAN.md)
- [Föy ile gereksinim eşleştirmesi](docs/SAGLAMA.md)
- [Test tablosu ve doğrulama sınırları](docs/TEST_TABLOSU.md)
- [Kısa rapor, hata notu, AI katkısı](docs/RAPOR.md)
- [Ekran görüntüleri](docs/EKRAN_GORUNTULERI.md)
- [Makine tarafından üretilen E2E sonuçları](docs/test-sonuclari.json)
- [Kaynak föy](docs/KAYNAK_FOY.md)
- [Önceki haftanın kaynak yedeği](docs/hafta5_kaynak_yedegi.zip)

## Veri ve korunan davranışlar

Arızalar ve görevler uygulama belleğinde tutulur; sayfa yenilenince veya uygulama yeniden başlatılınca örnek kayıtlara döner. Yeni arıza taslağı, liste araması ve durum filtresi ekran geçişlerinde korunur. Yeni kayıt en başa eklenir. Birim alanı konum olarak kullanılır. Arızalar `101`, `102`, `103`; ürünler `p1`–`p5`; dersler `d1`–`d4` kimliklerini kullanır.

Önceki haftanın formu ve liste görünümü `/onceki-ekran` rotasında da korunur. Bu arşiv görünümü kendi eski durumuyla çalışır; ana uygulamanın kayıtlarıyla ortak değildir. Ana uygulamadaki Yeni Arıza, liste ve detay ekranları ise aynı Context verisini paylaşır.

Föyün öğrenciye bıraktığı kişisel onay ve değerlendirmeler için [rapordaki açıklamayı](docs/RAPOR.md) okuyun. Öğrenci adı/numarası ve öğrenci tarafından yazılmış kişisel deneyim uydurulmamıştır.
