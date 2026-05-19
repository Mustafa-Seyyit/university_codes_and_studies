let x;

x = 5 + 5; // 10
x = 5 - 5; // 0
x = 5 * 5; // 25
x = 5 / 5; // 1
x = 7 % 5; //Mod işlemi : 2

//+ işlemi ile stringleri birleştirme
x = "Hello" + " " + "World"; // Hello World

//üs alma
x = 2 ** 3; // 8

//birer artma azaltma
x++;
x--;

// matematiksel operatörler ve =

x += 5; // x = x + 5 anlamına gelir.
x -= 5; // x = x - 5 anlamına gelir.
x *= 5; // x = x * 5 anlamına gelir.
x /= 5; // x = x / 5 anlamına gelir.
x %= 5; // x = x % 5 anlamına gelir.

//Matematiksel Operatörler ve Sayısal Tiplerde Zorlama

// BeklenenÇıktı (Gerekli Açıklama) şeklinde yorum satırlarını inceleyebilirsiniz.

let x;
x = 5 + "5";
console.log(typeof x, x); //string 55 (burada + operatörü 2 string'i birleştirme davranışını gösterdi)

x = 5 + Number("5");
console.log(typeof x, x); //number 10

x = 5 * "5";
console.log(typeof x, x); //number 25 (burada * operatörü "5" ifadesini sayısal olmaya zorladı ve dönüştürdü)

x = "6" * "5";
console.log(typeof x, x); //number 30 (burada * operatörü "6" ve "5" ifadelerini sayısal olmaya zorladı ve dönüştürdü)

x = 5 + null;
console.log(typeof x, x); //number 5 (+ operatörü null'ı 0 olarak kabul etti)

x = Number(null);
console.log(typeof x, x); // null değerini 0 olarak dönüştürür.

x = 5 + undefined;
console.log(typeof x, x); // number NaN (metamatiksel operatörler undefined verisini DÖNÜŞTÜREMEZLER)

x = Number(true);
console.log(typeof x, x); // number 1 true'nun sayısal dönüşüm karşılığı 1'dir. false'un 0'dır.

x = 5 + true;
console.log(typeof x, x); //number 6 (+ operatörü true değerini 1 olarak kabul etti)

x = 5 + false;
console.log(typeof x, x); //number 5(+ operatörü false değerini  0 olarak kabul etti)
