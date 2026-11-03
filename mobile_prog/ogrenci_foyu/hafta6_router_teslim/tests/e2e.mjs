import { chromium, expect } from '@playwright/test';
import { mkdir, writeFile } from 'node:fs/promises';
import { fileURLToPath } from 'node:url';
import { startServers } from './serve.mjs';
const out = fileURLToPath(new URL('../docs/ekranlar/', import.meta.url));
await mkdir(out, { recursive: true });
const stop = await startServers();
const browser = await chromium.launch({ channel: process.env.PLAYWRIGHT_CHANNEL || 'chrome', headless: true });
const context = await browser.newContext({ viewport: { width: 390, height: 844 }, deviceScaleFactor: 1, locale: 'tr-TR', reducedMotion: 'reduce' });
const page = await context.newPage();
const results = [], errors = [];
context.on('page', p => p.on('pageerror', e => errors.push(e.message)));
page.on('pageerror', e => errors.push(e.message));
const url = (app, route = '/') => `http://127.0.0.1:${8091 + app}${route}`;
const visibleText = (text, options = {}) => page.getByText(text, options).filter({ visible: true });
const visibleId = id => page.getByTestId(id).filter({ visible: true });
const btn = name => page.getByRole('button', { name, exact: true });
async function shot(name, height = 844) {
 await page.setViewportSize({ width: 390, height });
 await page.evaluate(() => document.fonts.ready);
 await page.screenshot({ path: `${out}${name}.png`, fullPage: true });
 await page.setViewportSize({ width: 390, height: 844 });
}
async function check(id, action, run) {
 try { await run(); results.push({ id, action, result: 'GEÇTİ' }); console.log(`✓ ${id} ${action}`); }
 catch (e) { results.push({ id, action, result: 'BAŞARISIZ', error: e.message }); await page.screenshot({ path: `${out}HATA-${id}.png` }); throw e; }
}
try {
 await check('T1', 'Ana sayfadan Arıza Listesine git', async () => {
  await page.goto(url(0)); await expect(btn('Arıza Listesi')).toBeVisible(); await shot('01-ariza-ana');
  await btn('Arıza Listesi').click(); await expect(page).toHaveURL(/\/arizalar$/); await expect(visibleId('toplam-sayisi')).toHaveText('3 talep'); await shot('02-ariza-liste', 1300);
 });
 await check('T2', '101 numaralı arızada doğru başlık, konum, durum', async () => {
  await btn('Projeksiyon görüntü vermiyor ayrıntılarını aç').click(); await expect(page).toHaveURL(/\/ariza\/101$/);
  await expect(visibleText('Lab 2', { exact: true })).toBeVisible(); await expect(visibleText('Bekliyor', { exact: true })).toBeVisible(); await shot('03-ariza-101', 1500);
 });
 await check('T3', 'Detaydan listeye dön ve ikinci kaydı aç', async () => {
  await btn('Listeye geri dön').click(); await expect(page).toHaveURL(/\/arizalar$/);
  await btn('Kablosuz ağ bağlantısı kesiliyor ayrıntılarını aç').click(); await expect(page).toHaveURL(/\/ariza\/102$/); await expect(visibleText('Kütüphane', { exact: true })).toBeVisible(); await shot('04-ariza-102', 1500);
  await btn('Listeye geri dön').click(); await btn('Yazıcı kâğıt sıkıştırıyor ayrıntılarını aç').click(); await expect(visibleText('Çözüldü', { exact: true })).toBeVisible(); await shot('05-ariza-103', 1500);
 });
 await check('T4', 'Bilinmeyen /ariza/999 ve doğrudan girişte geri dönüş', async () => {
  await page.goto(url(0, '/ariza/999')); await expect(visibleText('Arıza bulunamadı', { exact: true })).toBeVisible(); await shot('06-ariza-hatali-id');
  await btn('Listeye geri dön').click(); await expect(page).toHaveURL(/\/arizalar$/);
 });
 await check('E1', 'Arama ve filtre detaydan geri dönünce korunur', async () => {
  await page.getByLabel('Talep başlığında ara', { exact: true }).fill('AĞ'); await page.getByRole('radio', { name: 'Durum filtresi: İşlemde', exact: true }).click();
  await expect(visibleId('sonuc-sayisi')).toContainText('1 sonuç'); await btn('Kablosuz ağ bağlantısı kesiliyor ayrıntılarını aç').click(); await btn('Listeye geri dön').click();
  await expect(page.getByLabel('Talep başlığında ara', { exact: true })).toHaveValue('AĞ'); await expect(visibleId('sonuc-sayisi')).toContainText('1 sonuç');
 });
 await check('E2', 'Yeni Arıza: zorunlu alanlar ve Diğer kategori doğrulaması', async () => {
  await btn('Yeni Arıza').click(); await shot('07-yeni-ariza', 1700); await btn('Talebi Kaydet').click();
  await expect(page.getByRole('dialog')).toContainText('Eksik Bilgi'); await shot('08-form-hata'); await btn('Forma dön').click();
  await page.getByRole('textbox', { name: 'Ad Soyad', exact: true }).fill('Test Öğrencisi');
  await page.getByRole('textbox', { name: 'Birim', exact: true }).fill('Lab 3');
  await page.getByRole('textbox', { name: 'Arıza Başlığı', exact: true }).fill('Test ekranı açılmıyor');
  await page.getByRole('textbox', { name: 'Arıza Açıklaması', exact: true }).fill('Ekran güç kablosu takılıyken görüntü vermiyor.');
  await page.getByRole('radio', { name: 'Diğer', exact: true }).click(); await btn('Talebi Kaydet').click();
  await expect(page.getByRole('dialog')).toContainText('Arıza Türü Eksik'); await btn('Forma dön').click();
  await page.getByRole('textbox', { name: 'Diğer Arıza Türü', exact: true }).fill('Monitör');
 });
 await check('E3', 'Acil talep onayı, vazgeçme ve tek kayıt ekleme', async () => {
  await page.getByRole('switch', { name: 'Acil Müdahale Talebi' }).click(); await btn('Talebi Kaydet').click();
  await expect(page.getByRole('dialog')).toContainText('Acil talep onayı'); await shot('09-acil-onay'); await btn('Vazgeç').click();
  await expect(page.getByRole('textbox', { name: 'Arıza Başlığı', exact: true })).toHaveValue('Test ekranı açılmıyor');
  await btn('Talebi Kaydet').click(); await btn('Onayla ve kaydet').click();
  await expect(page).toHaveURL(/\/arizalar$/); await expect(visibleId('toplam-sayisi')).toHaveText('4 talep');
  await expect(btn('Test ekranı açılmıyor ayrıntılarını aç')).toBeVisible();
 });
 await check('E4', 'Durum değişikliği, silme iptali ve onaylı silme', async () => {
  await btn('Test ekranı açılmıyor ayrıntılarını aç').click(); await btn('Durum: Çözüldü').click();
  await expect(visibleText('Çözüldü', { exact: true })).toBeVisible(); await btn('Talebi sil').click();
  await expect(page.getByRole('dialog')).toContainText('Talep silinsin mi?'); await shot('10-silme-onayi'); await btn('Vazgeç').click();
  await expect(page).toHaveURL(/\/ariza\/TLP-/); await btn('Talebi sil').click(); await page.getByRole('dialog').getByRole('button', { name: 'Talebi sil', exact: true }).click();
  await expect(page).toHaveURL(/\/arizalar$/); await expect(visibleId('toplam-sayisi')).toHaveText('3 talep'); await expect(btn('Test ekranı açılmıyor ayrıntılarını aç')).toHaveCount(0);
 });
 await check('E5', 'Önceki haftanın form ve liste ekranları korunur', async () => {
  await page.goto(url(0, '/onceki-ekran')); await expect(page.getByRole('textbox', { name: 'Ad Soyad', exact: true })).toBeVisible(); await shot('11-onceki-form', 1800);
  await page.getByRole('radio', { name: 'Taleplerim görünümü' }).click(); await expect(visibleText('Henüz talebiniz yok')).toBeVisible(); await shot('12-onceki-liste');
 });
 await check('T5', 'Stoksuz ürün p2 detayında Stokta yok görünür', async () => {
  await page.goto(url(1)); await expect(btn('Mekanik Klavye detayını aç')).toBeVisible(); await shot('13-urun-liste', 1700);
  await btn('Mekanik Klavye detayını aç').click(); await expect(page).toHaveURL(/\/urun\/p2$/); await expect(visibleText('Stokta yok', { exact: true })).toBeVisible(); await expect(visibleText('0 adet', { exact: true })).toBeVisible(); await shot('14-urun-p2');
 });
 await check('T6', 'Ürün listesinden ikinci ürüne geç, doğru fiyat/açıklama', async () => {
  await btn('Listeye geri dön').click(); await btn('Kablosuz Fare detayını aç').click(); await expect(page).toHaveURL(/\/urun\/p1$/);
  await expect(visibleText('8 adet', { exact: true })).toBeVisible(); await expect(visibleText(/Bluetooth bağlantılı ergonomik fare/)).toBeVisible(); await expect(visibleText('₺450', { exact: true })).toBeVisible(); await shot('15-urun-p1');
  for (const [id, name] of [['p3','USB-C Çoklayıcı'],['p4','Kablosuz Kulaklık'],['p5','Taşınabilir SSD']]) {
   await btn('Listeye geri dön').click(); await btn(`${name} detayını aç`).click(); await expect(page).toHaveURL(new RegExp(`/urun/${id}$`)); await shot(`16-urun-${id}`);
  }
 });
 await check('E6', 'Hatalı ürün ID ve geri dönüş', async () => {
  await page.goto(url(1, '/urun/999')); await expect(visibleText('Ürün bulunamadı', { exact: true })).toBeVisible(); await shot('17-urun-hatali-id'); await btn('Listeye geri dön').click(); await expect(page).toHaveURL(url(1));
 });
 await check('T7', 'Dört dersin doğru gün, saat, sınıf, öğretim elemanı', async () => {
  await page.goto(url(2)); await shot('18-ders-liste', 1400);
  for (const [id, name, room, teacher] of [['d1','Mobil Programlama','Lab 2','Öğr. Gör. Deniz Yılmaz'],['d2','JavaScript','Lab 1','Öğr. Gör. Ece Kaya'],['d3','Web Tasarımı','Derslik 3','Öğr. Gör. Can Demir'],['d4','Veritabanı','Lab 4','Öğr. Gör. Selin Aksoy']]) {
   await btn(`${name} detayını aç`).click(); await expect(page).toHaveURL(new RegExp(`/ders/${id}$`));
   await expect(visibleText(room, { exact: true })).toBeVisible(); await expect(visibleText(teacher, { exact: true })).toBeVisible(); await shot(`19-ders-${id}`, 1000); await btn('Listeye geri dön').click();
  }
 });
 await check('E7', 'Gün/arama filtresi, boş sonuç, sıfırlama', async () => {
  await btn('Gün: Salı').click(); await page.getByRole('textbox', { name: 'Ders ara' }).fill('MOBİL'); await expect(visibleText('1 ders', { exact: true })).toBeVisible();
  await btn('Mobil Programlama detayını aç').click(); await btn('Listeye geri dön').click(); await expect(page.getByRole('textbox', { name: 'Ders ara' })).toHaveValue('MOBİL');
  await btn('Gün: Pazartesi').click(); await expect(visibleText('Ders bulunamadı', { exact: true })).toBeVisible(); await shot('20-ders-bos-filtre');
  await btn('Filtreleri temizle').click(); await expect(visibleText('4 ders', { exact: true })).toBeVisible();
 });
 await check('E8', 'Hatalı ders ID ve geri dönüş', async () => {
  await page.goto(url(2, '/ders/999')); await expect(visibleText('Ders bulunamadı', { exact: true })).toBeVisible(); await shot('21-ders-hatali-id'); await btn('Listeye geri dön').click(); await expect(page).toHaveURL(url(2));
 });
 await check('E9', 'Sekmeler: görev tamamlama, yeniden açma, profil', async () => {
  await page.goto(url(3)); await expect(visibleText('Mobil programlama ödevini tamamla', { exact: true })).toBeVisible(); await shot('22-gorevler');
  await btn('Tamamla').first().click(); await page.getByRole('tab', { name: /Tamamlananlar/ }).click();
  await expect(visibleText('Mobil programlama ödevini tamamla', { exact: true })).toBeVisible(); await shot('23-tamamlananlar');
  await btn('Yeniden aç').first().click(); await expect(btn('Yeniden aç')).toHaveCount(1);
  await page.getByRole('tab', { name: /Görevler/ }).click(); await expect(btn('Tamamla')).toHaveCount(2); await expect(visibleText('Mobil programlama ödevini tamamla', { exact: true })).toBeVisible();
  await page.getByRole('tab', { name: /Profil/ }).click(); await expect(visibleText('Toplam görev', { exact: true })).toBeVisible(); await shot('24-profil');
 });
 await check('E10', 'Tanımsız rota güvenli hata ekranı', async () => {
  for (let i = 0; i < 4; i++) { await page.goto(url(i, '/olmayan-sayfa')); await expect(visibleText('Sayfa bulunamadı', { exact: true })).toBeVisible(); await shot(`25-404-${i}`); await btn('Listeye geri dön').click(); await expect(page).toHaveURL(url(i)); }
 });
 await check('E11', 'Dar telefon ve masaüstünde yatay taşma yok', async () => {
  for (let app = 0; app < 4; app++) for (const width of [320, 1280]) {
   await page.setViewportSize({ width, height: 900 }); await page.goto(url(app));
   await expect(visibleText(app === 0 ? 'Her sorun, bir çözüme.' : app === 1 ? 'Çalışma alanına iyi gelir.' : app === 2 ? 'Haftanı planla.' : 'ADIM ADIM / GÖREV TAKİBİ', { exact: true })).toBeVisible();
   const overflow = await page.evaluate(() => document.documentElement.scrollWidth > innerWidth); expect(overflow).toBe(false);
   if (width === 1280) await page.screenshot({ path: `${out}26-masaustu-${app}.png` });
  }
 });
 await check('E12', 'Tarayıcı çalışma zamanı hatası yok', async () => { expect(errors).toEqual([]); });
} finally {
 await writeFile(new URL('../docs/test-sonuclari.json', import.meta.url), JSON.stringify({ date: '2026-10-27', platform: 'Expo web export / Chrome / 390×844, 320×900, 1280×900', results, runtimeErrors: errors }, null, 2));
 await browser.close(); await stop();
}
