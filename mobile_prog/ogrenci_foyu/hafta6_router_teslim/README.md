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

