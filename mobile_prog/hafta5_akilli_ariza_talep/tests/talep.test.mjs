import assert from 'node:assert/strict';
import test from 'node:test';
import {
  bosFormOlustur, formuDogrula, sonrakiKayitZamani, talebiEkle, talebiHazirla,
  talebiSil, talebinDurumunuDegistir, talepleriFiltrele, talepleriSay,
} from '../src/utils/talep.js';

const gecerli = {
  adSoyad: 'Ayşe Yılmaz', birim: 'Öğrenci İşleri', baslik: 'Bilgisayar açılmıyor',
  aciklama: 'Bilgisayar güç düğmesine basıldığında açılmıyor.',
  kategori: 'Bilgisayar', digerKategori: '', oncelik: 'Orta', acil: false,
};

test('T01: boş form eksik bilgi uyarısı verir', () => {
  const sonuc = formuDogrula({ ...gecerli, adSoyad: '', birim: '', baslik: '', aciklama: '', kategori: '' });
  assert.equal(sonuc.uyari.baslik, 'Eksik Bilgi');
  assert.deepEqual(Object.keys(sonuc.hatalar), ['adSoyad', 'birim', 'baslik', 'aciklama', 'kategori']);
});

for (const alan of ['adSoyad', 'birim', 'baslik']) {
  test('T02: ' + alan + ' yalnızca boşluk olamaz', () => {
    const sonuc = formuDogrula({ ...gecerli, [alan]: ' \t\n ' });
    assert.equal(sonuc.uyari.baslik, 'Eksik Bilgi');
    assert.ok(sonuc.hatalar[alan]);
  });
}

test('T03: kısa açıklama reddedilir; sınır 10 karakterdir', () => {
  for (const aciklama of ['', 'abcde', '123456789', '   12345   ', '          ']) {
    assert.equal(formuDogrula({ ...gecerli, aciklama }).uyari.baslik, 'Geçersiz Açıklama');
  }
  assert.equal(formuDogrula({ ...gecerli, aciklama: ' 1234567890 ' }).uyari, null);
});

test('T04: kategori seçimi zorunludur', () => {
  assert.equal(formuDogrula({ ...gecerli, kategori: '' }).uyari.baslik, 'Kategori Eksik');
});

test('Görev 1: Diğer türü boşluk olamaz ve normal kategorilerde zorunlu değildir', () => {
  assert.equal(formuDogrula({ ...gecerli, kategori: 'Diğer', digerKategori: '   ' }).uyari.baslik, 'Arıza Türü Eksik');
  assert.equal(formuDogrula({ ...gecerli, kategori: 'Diğer', digerKategori: 'Projeksiyon' }).uyari, null);
  assert.equal(formuDogrula(gecerli).uyari, null);
});

test('G4: kayıt tüm alanları, Türkçe tarihi ve Bekliyor durumunu içerir', () => {
  const zaman = 1791882000000;
  const talep = talebiHazirla({ ...gecerli, oncelik: 'Yüksek', acil: true }, zaman);
  assert.equal(talep.id, 'TLP-' + zaman);
  assert.equal(talep.durum, 'Bekliyor');
  assert.equal(talep.tarih, new Date(zaman).toLocaleString('tr-TR'));
  assert.equal(talep.acil, true);
  assert.equal(talep.oncelik, 'Yüksek');
  assert.equal(talep.adSoyad, gecerli.adSoyad);
  assert.equal(talep.aciklama, gecerli.aciklama);
});

test('Kayıt metinleri trim edilir ve form nesnesi korunur', () => {
  const form = { ...gecerli, adSoyad: ' Ayşe Yılmaz ', birim: ' Öğrenci İşleri ', baslik: ' Arıza ', aciklama: ' Uzun arıza açıklaması ', kategori: 'Diğer', digerKategori: ' Projeksiyon ' };
  const onceki = { ...form };
  const talep = talebiHazirla(form, 1791882000000);
  assert.equal(talep.adSoyad, 'Ayşe Yılmaz');
  assert.equal(talep.birim, 'Öğrenci İşleri');
  assert.equal(talep.baslik, 'Arıza');
  assert.equal(talep.aciklama, 'Uzun arıza açıklaması');
  assert.equal(talep.digerKategori, 'Projeksiyon');
  assert.deepEqual(form, onceki);
});

test('Başka kategorideki kayıt gizli Diğer metnini içermez', () => {
  assert.equal(talebiHazirla({ ...gecerli, digerKategori: 'Eski giriş' }, 1791882000000).digerKategori, '');
});

test('G2: tanımsız kategori geçerli kabul edilmez', () => {
  assert.equal(formuDogrula({ ...gecerli, kategori: 'Geçersiz' }).uyari.baslik, 'Kategori Eksik');
});

test('G4: yeni kayıt önceki kayıtları koruyarak en başa eklenir', () => {
  const ilk = talebiHazirla(gecerli, 1000);
  const ikinci = talebiHazirla({ ...gecerli, baslik: 'Yazıcı sorunu', kategori: 'Yazıcı' }, 1001);
  const onceki = Object.freeze([Object.freeze(ilk)]);
  const sonraki = talebiEkle(onceki, ikinci);
  assert.deepEqual(sonraki, [ikinci, ilk]);
  assert.deepEqual(onceki, [ilk]);
  assert.equal(talebiEkle(sonraki, ikinci).length, 2);
});

test('G4: aynı milisaniyede ve saat geri alınsa da kimlikler çakışmaz', () => {
  let son = 0;
  const kimlikler = [1000, 1000, 999, 1002, 2000].map((simdi) => {
    son = sonrakiKayitZamani(simdi, son);
    return talebiHazirla(gecerli, son).id;
  });
  assert.equal(new Set(kimlikler).size, 5);
});

test('G6: silme yalnızca seçilen kaydı kaldırır, önceki diziyi değiştirmez', () => {
  const ilk = talebiHazirla(gecerli, 1000);
  const ikinci = talebiHazirla(gecerli, 1001);
  const onceki = Object.freeze([Object.freeze(ilk), Object.freeze(ikinci)]);
  assert.deepEqual(talebiSil(onceki, ilk.id), [ikinci]);
  assert.deepEqual(talebiSil(onceki, 'bulunamayan'), onceki);
  assert.equal(onceki.length, 2);
});

test('G7: hedef kayıt üç durum arasında her iki yönde değiştirilebilir', () => {
  const ilk = talebiHazirla(gecerli, 1000);
  const ikinci = talebiHazirla(gecerli, 1001);
  let talepler = [ilk, ikinci];
  for (const durum of ['İşlemde', 'Tamamlandı', 'Bekliyor', 'Tamamlandı']) {
    talepler = talebinDurumunuDegistir(talepler, ilk.id, durum);
    assert.equal(talepler[0].durum, durum);
    assert.equal(talepler[1].durum, 'Bekliyor');
  }
  assert.equal(ilk.durum, 'Bekliyor');
  assert.deepEqual(talebinDurumunuDegistir(talepler, ilk.id, 'Geçersiz'), talepler);
});

test('Özgün özellik: Türkçe arama ve durum filtresi birlikte çalışır', () => {
  const talepler = [
    talebiHazirla({ ...gecerli, baslik: 'İNTERNET bağlantısı kesildi' }, 1000),
    { ...talebiHazirla({ ...gecerli, baslik: 'Yazıcı çalışmıyor' }, 1001), durum: 'İşlemde' },
    { ...talebiHazirla({ ...gecerli, baslik: 'İnternet çok yavaş' }, 1002), durum: 'Tamamlandı' },
  ];
  assert.equal(talepleriFiltrele(talepler, '  internet  ', 'Tümü').length, 2);
  assert.equal(talepleriFiltrele(talepler, 'İNTERNET', 'Bekliyor')[0].id, 'TLP-1000');
  assert.equal(talepleriFiltrele(talepler, 'YAZICI', 'İşlemde')[0].id, 'TLP-1001');
  assert.equal(talepleriFiltrele(talepler, 'internet', 'İşlemde').length, 0);
  assert.equal(talepleriFiltrele(talepler, '   ', 'Tümü').length, 3);
});

test('Sayaçlar filtrelerden bağımsızdır; güncelleme ve silme anında yansır', () => {
  let talepler = [talebiHazirla(gecerli, 1000), talebiHazirla(gecerli, 1001)];
  assert.deepEqual(talepleriSay(talepler), { toplam: 2, bekliyor: 2, islemde: 0, tamamlanan: 0 });
  talepler = talebinDurumunuDegistir(talepler, 'TLP-1000', 'Tamamlandı');
  assert.deepEqual(talepleriSay(talepler), { toplam: 2, bekliyor: 1, islemde: 0, tamamlanan: 1 });
  assert.equal(talepleriFiltrele(talepler, '', 'Bekliyor').length, 1);
  talepler = talebiSil(talepler, 'TLP-1000');
  assert.deepEqual(talepleriSay(talepler), { toplam: 1, bekliyor: 1, islemde: 0, tamamlanan: 0 });
});

test('Form sıfırlama bağımsız nesneler üretir ve boş liste desteklenir', () => {
  const ilk = bosFormOlustur();
  ilk.baslik = 'Taslak';
  assert.equal(bosFormOlustur().baslik, '');
  assert.equal(bosFormOlustur().oncelik, 'Orta');
  assert.equal(bosFormOlustur().acil, false);
  assert.deepEqual(talepleriFiltrele([], 'yazıcı', 'Bekliyor'), []);
  assert.deepEqual(talepleriSay([]), { toplam: 0, bekliyor: 0, islemde: 0, tamamlanan: 0 });
});
