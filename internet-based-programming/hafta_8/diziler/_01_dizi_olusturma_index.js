let x;
//Dizi Oluşturma yöntem-1
const numbers = [10, 20, 5, 24, 61, 19];

//Dizi Oluşturma yöntem-2 (Array Constructor)
const fruits = new Array("Apple", "Grape", "Orange");

//Diziyi Oluşturma Yöntem-3 (Array.of() metodu)
Array.of("Ahmet", "Mehmet", "Selin", "Fatma");

//Bir dizide farklı türden elemanları barındırabiliriz.
const mixed = [91, "Hello", 32.4, false, null, undefined, "World"];

x = numbers[0]; //ilk elemanı alır
console.log(x);

x = `My favorite fruit is an ${fruits[2]}`;
console.log(x); // My favorite fruit is an Orange

//3. elemanın(2.indexteki) eğerini değiştirelim.
fruits[2] = "pear";

console.log(`fruits dizisinde ${fruits.length} tane eleman var`);

console.log(`fruits dizisinde ${fruits.length} tane eleman var`);

//diziye yeni eleman ekleme
fruits[fruits.length] = "Blueberry";
fruits[fruits.length] = "Peach";
console.log(`fruits dizisinde ${fruits.length} tane eleman var`);
