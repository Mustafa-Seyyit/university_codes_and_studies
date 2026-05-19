d = new Date();
console.log(typeof d, d);

d = Date.now(); //Şu anki zamanı timestamp (milisaniye cinsinden) verir.
console.log(d);

// Belirli bir tarih ve saat oluşturma
d = new Date(2025, 11, 1, 11, 10, 25);
console.log(d);

console.log(new Date(1764576625000));
