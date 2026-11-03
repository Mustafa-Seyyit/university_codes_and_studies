import test from 'node:test';
import assert from 'node:assert/strict';
import { tickets } from '../apps/ariza_takip/src/data/tickets.js';
import { products, stockLabel, formatPrice } from '../apps/urun_katalogu/src/data/products.js';
import { courses, filterCourses } from '../apps/ders_programi/src/data/courses.js';
import { durumlar } from '../apps/ariza_takip/src/utils/talep.js';
import '../apps/ariza_takip/tests/talep.test.mjs';

test('Föy veri sözleşmeleri: benzersiz ID, zorunlu alanlar ve asgari kayıtlar', () => {
 for (const [items, min, fields] of [[tickets, 3, ['id', 'baslik', 'birim', 'durum']], [products, 5, ['id', 'name', 'price', 'category', 'stock', 'description']], [courses, 4, ['id', 'name', 'day', 'time', 'room', 'instructor']]]) {
  assert.ok(items.length >= min); assert.equal(new Set(items.map(x => x.id)).size, items.length);
  for (const item of items) for (const field of fields) assert.notEqual(item[field], undefined);
 }
 assert.ok(tickets.some(t => t.id === '101'));
 assert.deepEqual(new Set(tickets.map(t => t.durum)), new Set(durumlar));
});
test('Stok ve fiyat sunumu: sıfır, pozitif ve Türkçe lira', () => {
 assert.equal(stockLabel(0), 'Stokta yok'); assert.equal(stockLabel(8), 'Stokta');
 assert.equal(products.find(p => p.id === 'p2').stock, 0); assert.match(formatPrice(1800), /1\.800/);
 for (const p of products) { assert.ok(p.price > 0); assert.ok(Number.isInteger(p.stock) && p.stock >= 0); }
});
test('Ders filtresi Türkçe büyük/küçük harf ve boş sonuç destekler', () => {
 assert.equal(filterCourses('Tümü', '').length, 4);
 assert.deepEqual(filterCourses('Salı', ' MOBİL ').map(c => c.id), ['d1']);
 assert.equal(filterCourses('Pazartesi', '').length, 0);
 assert.equal(filterCourses('Cuma', 'javascript').length, 0);
});
test('Olmayan ID hiçbir veri kümesinde yanlış kaydı seçmez', () => {
 for (const items of [tickets, products, courses]) assert.equal(items.find(x => x.id === '999'), undefined);
});
