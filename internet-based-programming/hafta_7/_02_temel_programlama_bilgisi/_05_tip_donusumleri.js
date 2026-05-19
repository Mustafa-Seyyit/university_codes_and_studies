console.log(typeof degiskenAdi);

//Sayısal Değere Dönüştürme

let amount1 = "250";
let amount2 = "350";
let amount3 = "450";

console.log(typeof amount1, amount1); // string 250

//sayıya dönüştürelim.
amount1 = parseInt(amount1); //parseInt Metodu
amount2 = +amount2; // + operatörü
amount3 = Number(amount3); // Number metodu

console.log(typeof amount1, amount1); // number 250
console.log(typeof amount2, amount2); // number 350
console.log(typeof amount3, amount3); // number 450

let number1 = "34";
let number2 = "otuzdort";

number1 = Number(number1);
number2 = Number(number2);
console.log(typeof number1, number1); // number 34
console.log(typeof number2, number2); // number NaN

console.log(Math.sqrt(-1)); //reel sayılar için karekök içi negatif olamayacağı için NaN döner
console.log(1 + NaN); // + işlemi gerçekleşmez. Sonuç NaN olur
console.log(undefined + undefined); //  + işlemi gerçekleşmez. Sonu. NaN olur
console.log("ahmet" / "yilmaz"); //  / işlemi gerçekleşmez. Sonu. NaN olur

//String’e Dönüştürme

let amount1 = 250;
let amount2 = 350;
let amount3 = 450;

console.log(typeof amount1, amount1); // number 250

//number tipindeki bu verileri string'e dönüştürelim.
amount1 = String(amount1);
amount2 = amount2.toString();
amount3 = `${amount3}`;

console.log(typeof amount1, amount1); // string 250
console.log(typeof amount2, amount2); // string 350
console.log(typeof amount3, amount3); // string 450

//Boolean Dönüşümü

let v1 = "ahmet"; //içeriğinden bağımsız bir karakter bile varsa true olujr
let v2 = ""; //boş string ifadesi false olur
let v3 = 3; // sayısal değerlerde 0'dan farklı değerler true, 0 false olarak kabul eidlir.
let v4 = 0;

v1 = Boolean(v1); // true
v2 = Boolean(v2); // false
v3 = Boolean(v3); // true
v4 = Boolean(v4); // false

console.log(v1); // true
console.log(v2); // false
console.log(v3); // true
console.log(v4); // false
