// VAR

var x = 5;
var x = 10; // Hata vermez, yeniden tanımlanabilir

// LET

let y = 5;
// let y = 10; // Hata verir: Aynı blokta yeniden tanımlanamaz
y = 15; // Bu olur, değeri değiştirilebilir

// CONST

const z = 7;
// z = 8; // Hata verir: const ile tanımlanan değişken değiştirilemez

const user = { name: "Ahmet" };
user.name = "Aki"; // Bu olur, çünkü nesnenin içeriği değiştirilebilir.

const arr = [1, 2, 3, 4];
arr.push(5); // hata vermez ve diziye yeni bir eleman ekler.

// arr = [1, 2, 3, 4, 5, 6]; // hata verir. Çünkü yeniden atama yapıyoruz.
