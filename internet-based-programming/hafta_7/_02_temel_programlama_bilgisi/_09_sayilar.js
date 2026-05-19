//sayı tanımlama

let x = 5; //sayı tanımlama
console.log(typeof x); //primitive tip olan number
//sayıları aşağıdaki gibi de tanımlayabiliriz
const num = new Number(5);
console.log(typeof num); //object olur. Çünkü Number(number değil) türünden bir nesnedir

//Sayılarla ilgili bazı metotlar ve kullanımları.

const num = new Number(5);

console.log(num.toString());

console.log(num.toString().length); //dikkat: önce string'e çeviriyoruz. sonra o stringin karakter sayısını alıyoruz.

console.log(num.toFixed(3)); //. noktadan sonra kaç basamak olsun bunu belirtiyoruz. Eğer ilgili son basamak değeri 5 veya daha büyükse yukarı yuvarlar Örneğin 456'yı 46 yapar.

console.log((5.47513).toFixed(2)); //475'i 48 yapar

console.log((25).toPrecision(3)); //25.0 (Sayıyı 3 basamakla göster)

console.log(num.toExponential(2)); // 5.00e+0 yani 5x10^1 anlamına gelir.
console.log((150).toExponential(3)); // 1.500e+2 yani 1.5 * 10^2 anlamına gelir.

console.log((51241).toLocaleString("en-US")); // 51,241  => 3'lü basamak  virgül ile ayrılmıştır
console.log((51241).toLocaleString("tr-TR")); // 51.241  => 3'lü basamak  nokta ile ayrılmıştır
console.log(num.valueOf());
console.log(Number.MAX_VALUE);
console.log(Number.MIN_VALUE);
console.log(Number.POSITIVE_INFINITY); //+Sonsuz
console.log(Number.NEGATIVE_INFINITY); // - Sonsuz
console.log(Number.MIN_VALUE > Number.NEGATIVE_INFINITY); //true döner

//Math ile matematiksel işlemler

let x;

//sqrt=>Karekök alma
console.log(Math.sqrt(9)); // 3

//abs=> mutlak değer
console.log(Math.abs(-5)); //5

//round=>  ondalıklı kısmın büyüklüğüne göre üste(.5 ve sonrası) veya alta(.5'den küçük) yuvarlar
console.log(Math.round(4.299999)); //4'e yuvarlar. (.5 ve sonrasını üste yuvarlar. Aksi halde alta yuvarlar.)
console.log(Math.round(4.50001)); // 5'e yuvarlar
//ceil => tavana yuvarlama
console.log(Math.ceil(4.11)); //5 => Her zaman bir üste yuvarlar

//floor => tabana yuvarlama
console.log(Math.floor(4.9)); //4 => Her zaman bir alta yuvarlar

//üs alma
console.log(Math.pow(3, 4)); // 81  3^4

//min ve max => Gönderilen sayılar arasında en küçük ve en büyük sayıları döner
console.log(Math.min(3, 4, 5, 6, 7, -1, 8, 9, 1));
console.log(Math.max(3, 4, 5, 6, 7, -1, 8, 9, 1));

//random=> 0-1 arasında rastgele değer üretir
console.log(Math.random());

//random ile istediğiniz 2 TAM SAYI arasında değer üretmek için aşağıdaki yapıyı kullanabilirsiniz.
//Math.floor(Math.random() * (max - min + 1)) + min; (Ezberlemenize gerek yok)
//Mesela 5 - 20 arasında rastgele bir tam sayı üretelim.
console.log(Math.floor(Math.random() * 16) + 5);
