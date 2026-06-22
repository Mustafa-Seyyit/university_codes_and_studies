# Introducing to Machine Learning — Türkçe Çalışma Notları

Bu repo, Python ile veri analizi ve makine öğrenmesine giriş için hazırlanmış Türkçe bir Jupyter Notebook içerir. Notebook, Pokémon istatistikleri veri seti üzerinden temel veri bilimi akışını gösterir.

## İçerik

- Veri setini yükleme ve ilk kontroller
- Eksik değer analizi
- Korelasyon ve temel görselleştirme
- Python kısa tekrar: sözlükler, döngüler, fonksiyonlar, `apply`
- Pandas ile filtreleme, gruplama, pivot ve melt işlemleri
- Basit Random Forest sınıflandırma modeli
- Kısa alıştırmalar

## Dosyalar

- `introducing_to_machine_learning_turkce_notlar.ipynb`: Ana ders notu
- `pokemon.csv`: Notebook'u çalıştırmak için gerekli veri dosyası. Bu dosyayı repoya ekleyebilir veya `data/` klasörü altına koyabilirsiniz.

## Kurulum

Gerekli kütüphaneler:

```bash
pip install numpy pandas matplotlib seaborn scikit-learn notebook
```

Notebook içinde veri yolu esnek tutulmuştur. Aşağıdaki konumlardan biri kullanılabilir:

```text
pokemon.csv
data/pokemon.csv
../input/pokemon.csv
/kaggle/input/pokemon/Pokemon.csv
```

## Not

Veri seti Kaggle üzerinde yaygın kullanılan Pokémon istatistikleri veri setidir. GitHub'a yüklerken veri setinin lisans/kaynak bilgisini repo açıklamasında belirtmeniz önerilir.
