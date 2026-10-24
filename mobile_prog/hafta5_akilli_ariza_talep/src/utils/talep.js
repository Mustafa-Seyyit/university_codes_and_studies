// Önceki haftanın kategorileri, öncelikleri ve form doğrulaması korunur.
export const kategoriler = [
  { ad: 'Bilgisayar', ikon: 'desktop-outline' },
  { ad: 'Yazıcı', ikon: 'print-outline' },
  { ad: 'İnternet', ikon: 'wifi-outline' },
  { ad: 'Yazılım', ikon: 'code-slash-outline' },
  { ad: 'Diğer', ikon: 'ellipsis-horizontal-outline' },
];

export const oncelikler = ['Düşük', 'Orta', 'Yüksek'];

export const oncelikRenkleri = {
  Düşük: { koyu: '#15803D', acik: '#F0FDF4' },
  Orta: { koyu: '#C2410C', acik: '#FFF7ED' },
  Yüksek: { koyu: '#B91C1C', acik: '#FEF2F2' },
};

export function formuDogrula(form) {
  const hatalar = {};
  if (!form.adSoyad.trim()) hatalar.adSoyad = 'Adınızı ve soyadınızı giriniz.';
  if (!form.birim.trim()) hatalar.birim = 'Çalıştığınız birimi giriniz.';
  if (!form.baslik.trim()) hatalar.baslik = 'Arıza başlığını giriniz.';
  if (form.aciklama.trim().length < 10) hatalar.aciklama = 'Arıza açıklaması en az 10 karakter olmalıdır.';
  if (!kategoriler.some((item) => item.ad === form.kategori)) {
    hatalar.kategori = 'Lütfen bir arıza kategorisi seçiniz.';
  }
  if (form.kategori === 'Diğer' && !form.digerKategori.trim()) {
    hatalar.digerKategori = 'Lütfen diğer arıza türünü açıklayınız.';
  }

  // Uyarı sırası laboratuvar föyündeki doğrulama sırasıyla aynıdır.
  let uyari = null;
  if (hatalar.adSoyad || hatalar.birim || hatalar.baslik) {
    uyari = { baslik: 'Eksik Bilgi', mesaj: 'Lütfen zorunlu alanları doldurunuz.' };
  } else if (hatalar.aciklama) {
    uyari = { baslik: 'Geçersiz Açıklama', mesaj: hatalar.aciklama };
  } else if (hatalar.kategori) {
    uyari = { baslik: 'Kategori Eksik', mesaj: hatalar.kategori };
  } else if (hatalar.digerKategori) {
    uyari = { baslik: 'Arıza Türü Eksik', mesaj: hatalar.digerKategori };
  }
  return { hatalar, uyari };
}

// Sadece doğrulama ve gerekiyorsa acil talep onayından sonra çağrılır.
export function talebiHazirla(form, zaman) {
  return {
    id: 'TLP-' + zaman,
    adSoyad: form.adSoyad.trim(),
    birim: form.birim.trim(),
    baslik: form.baslik.trim(),
    aciklama: form.aciklama.trim(),
    kategori: form.kategori,
    digerKategori: form.kategori === 'Diğer' ? form.digerKategori.trim() : '',
    oncelik: form.oncelik,
    acil: form.acil,
    durum: 'Bekliyor',
    tarih: new Date(zaman).toLocaleString('tr-TR'),
  };
}

export const durumlar = ['Bekliyor', 'İşlemde', 'Tamamlandı'];
export const durumRenkleri = {
  Bekliyor: { koyu: '#A46012', acik: '#FFF4E3' },
  İşlemde: { koyu: '#2459CC', acik: '#EDF2FF' },
  Tamamlandı: { koyu: '#19734E', acik: '#EAF7EF' },
};

export function bosFormOlustur() {
  return {
    adSoyad: '', birim: '', baslik: '', aciklama: '',
    kategori: '', digerKategori: '', oncelik: 'Orta', acil: false,
  };
}

// Saat geri alınsa veya iki kayıt aynı milisaniyede oluşsa da kimlik çakışmaz.
export function sonrakiKayitZamani(simdi, sonZaman) {
  return Math.max(simdi, sonZaman + 1);
}

export function talebiEkle(talepler, yeniTalep) {
  if (talepler.some((talep) => talep.id === yeniTalep.id)) return talepler;
  return [yeniTalep, ...talepler];
}

export function talebiSil(talepler, id) {
  return talepler.filter((talep) => talep.id !== id);
}

// Tamamlandı → Bekliyor dahil her geçerli durum doğrudan seçilebilir.
export function talebinDurumunuDegistir(talepler, id, yeniDurum) {
  if (!durumlar.includes(yeniDurum)) return talepler;
  return talepler.map((talep) =>
    talep.id === id ? { ...talep, durum: yeniDurum } : talep,
  );
}

export function talepleriFiltrele(talepler, arama, durumFiltresi) {
  const sorgu = arama.trim().toLocaleLowerCase('tr-TR');
  return talepler.filter((talep) =>
    (durumFiltresi === 'Tümü' || talep.durum === durumFiltresi) &&
    talep.baslik.toLocaleLowerCase('tr-TR').includes(sorgu),
  );
}

export function talepleriSay(talepler) {
  return {
    toplam: talepler.length,
    bekliyor: talepler.filter((talep) => talep.durum === 'Bekliyor').length,
    islemde: talepler.filter((talep) => talep.durum === 'İşlemde').length,
    tamamlanan: talepler.filter((talep) => talep.durum === 'Tamamlandı').length,
  };
}
