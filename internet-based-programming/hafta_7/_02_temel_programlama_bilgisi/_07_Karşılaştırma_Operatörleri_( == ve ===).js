//(Gevşek eşitlik — loose equality)

5 == "5"; // true → çünkü '5' stringi sayıya çevrilir
true == 1; // true → true sayıya çevrilir (1)
true == 9; // false -> sayısal olarak true'nun değeri 1'dir.
null == undefined; // true → null ve undefined kıyaslanırsa eşit varsayılıyor

//=== (Sıkı eşitlik — strict equality)

5 === "5"; // false → çünkü biri sayı, biri string
true === 1; // false → türler farklı
null === undefined; // false → türler farklı

5 === 5; // true
"merhaba" === "merhaba"; // true

//diğer karşılaştırma operatörleri

console.log(5 > 4);
console.log(5 < 4);
console.log(5 >= 4);
console.log(5 <= 4);
