let str = "Hello World";
console.log(str[0]); // H
console.log(str[str.length - 1]); //d

//concat()

let firstName = "Ahmet";
let lastName = "Yilmaz";

let fullName1 = firstName.concat(lastName);
let fullName2 = firstName + " " + lastName;
let fullName3 = `${firstName} ${lastName}`;
console.log(fullName1, fullName2, fullName3);

//indexof() ve lastindexof() metodu

let message = "Hi From Internet Programming Course";

console.log(message.indexOf("From")); //3
console.log(message.indexOf("o")); // 5
console.log(message.indexOf("G")); //-1

let message = "Hi From Internet Programming Course";

console.log(message.lastIndexOf("o")); //30
console.log(message.lastIndexOf("test")); //-1

let message = "Hi From Internet Programming Course";

console.log(message.indexOf("o")); //5
console.log(message.indexOf("o", 6)); // 19 (6. karakterden itibaren aramaya başlar.)
console.log(message.indexOf("rog")); // 18
console.log(message.indexOf("rog", 19)); // -1 (19. karakterden sonra rog ifadesi olmadığı için -1 döner)

//search

let message = "Hi From Internet Programming Course";

console.log(message.search("Internet")); //8
console.log(message.search(""));

//Search ve Regular Expression ile Örnek (Regular Expressiondan Sınavda Sorumlu Değilsiniz.)

//1-Büyük-küçük harf duyarsız arama (i bayrağı)
let sentence = "JavaScript is fun!";
console.log(sentence.search(/javascript/i)); // 0 (Normalde "JavaScript" ile "javascript" farklıdır, ama i bayrağı sayesinde fark etmez.)
//2- Sayı arama
let info = "Your total score is 98 out of 100.";
console.log(info.search(/\d+/)); // 21 (\d+ bir veya daha fazla rakam)

//toUpperCase() ve toLowerCase()

let str1 = "Hello World!";
let str2 = str1.toUpperCase(); // HELLO WORLD!
let str3 = str1.toLowerCase(); // hello world!

//trim(), trimStart(), trimEnd()

let message = "        Merhaba bugün günlerden pazartesi     ";
console.log(message, message.length); //normalde string ifade 46 karakterli
console.log(message.trimStart(), message.trimStart().length); //baştakileri temizler
console.log(message.trimEnd(), message.trimEnd().length); //Sondakileri temizler
console.log(message.trim(), message.trim().length); //hem sol hem de sağdakileri temizler

//slice()

let str = "Audi, Porsche, Şahin, Mercedes, Ferrari.";
console.log(str.slice(15, 20)); // Şahin

let str = "Audi, Porsche, Şahin, Mercedes, Ferrari.";
console.log(str.slice(-8, -1)); // Ferrari

let str = "Audi, Porsche, Şahin, Mercedes, Ferrari.";
console.log(str.slice(15)); // Şahin, Mercedes, Ferrari.

//substring()

let str = "Ankara,İstanbul,İzmir,Diyarbakır,Siirt";
console.log(str.substring(7, 15)); // İstanbul
console.log(str.substring(7)); // İstanbul,İzmir,Diyarbakır,Siirt

//substr() - deprecated yani yakın zamanda kaldırılabilir. Kullanımı tavsiye edilmez -

let str = "Ankara,İstanbul,İzmir,Diyarbakır,Siirt";
let city = "İstanbul";

//ilk parametreyle İstanbul'un geçtiği yerin ilk index'ini başlangıç noktası olarak belirliyoruz
//ikinci parametreyle alınması gereken karakter sayısı olarak length veriyoruz.
console.log(str.substr(str.indexOf(city), city.length));

//replace() ve replaceAll()

let str = "Ankara,İstanbul,İzmir,Siirt";

console.log(str.replace(",", "-")); // Ankara-İstanbul,İzmir,Siirt
console.log(str.replaceAll(",", "-")); // Ankara-İstanbul-İzmir-Siirt

//split()

let str = "Ankara,İstanbul,İzmir,Siirt";

let cities = str.split(","); // Ayrım sonucu ifadeler dizi olarak cities değişkenine atanır
console.log(`${cities.length} tane şehir bulundu`); // 4 tane şehir bulundu

//charArt()

let str = "Hello World";
console.log(str[0]); // H
console.log(str.charAt(0)); // H

console.log(str[str.length - 1]); //d
console.log(str.charAt(str.length - 1)); //d

//ÖRNEK KULLANIMLAR

//1- Cümle kaç karakterlidir ?

console.log(sentence.length);

//2- Kaç kelimeden oluşuyor ?

console.log(sentence.trim().split(" ").length);

//3- Tüm cümleyi küçük harfe çevirin.

console.log(sentence.toLowerCase());
console.log(sentence.toUpperCase());

//4-Cümlenin başındaki ve sonundaki boşlukları siliniz.

console.log(sentence.trim());

//5- '-' karakterini silin.

console.log(sentence.replace("-", ""));

//6- url'nin içinden str kısmını çıkarınız.

var str = "http://";
console.log(url.substr(str.length));
console.log(url.slice(str.length));

//7- Url hangi protocol'u kullanmaktadır ? (http,https)

console.log(url.startsWith("http"));
console.log(url.startsWith("https"));

//8- url, '.com' ifadesini içeriyor mu?

console.log(url.indexOf(".com"));
console.log(url.includes(".com"));

//9- url string ifadesini geçerli bir url olarak düzenleyiniz.

console.log(
  url
    .toLowerCase()
    .replace(/ /g, "-")
    .replace(/ı/g, "i")
    .replace(/ü/g, "u")
    .replace(/ö/g, "o")
    .replace(/ş/g, "s")
    .replace(/ç/g, "c"),
);
