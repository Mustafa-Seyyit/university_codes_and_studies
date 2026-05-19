let x;

const arr = [45, 51, 71, 25, 32];
//dizinin sonuna yeni bir eleman ekler.
arr.push(100);
console.log(arr); // [ 45, 51, 71, 25, 32, 100 ]

//pop metodu dizinin son elemanını diziden çıkarıp geri döner
let lastValue = arr.pop(); //lastValue = 100
console.log(lastValue, arr); //100 [ 45, 51, 71, 25, 32 ]

//dizinin başına yeni bir eleman ekler
arr.unshift(99);
console.log(arr); //[ 99, 45, 51, 71, 25, 32 ]

//Dizinin ilk elemanını siler ve geri döner.
let firstValue = arr.shift(); //99
console.log(firstValue, arr); //99 [ 45, 51, 71, 25, 32 ]

//Diziyi ters çevirir
arr.reverse();
console.log(arr); //[ 32, 25, 71, 51, 45 ]

//dizideki ilgili elemanın index değerini döndürür
console.log(arr.indexOf(71)); // 2

//includes metodu kendisine gönderilen parametre dizi içinde yer alıyorsa true, yer almıyorsa false döner.
console.log(arr.includes(61)); // false

//dizideki elemanların arasına belirtilen karakteri koyarak birleştirir ve tek bir string haline getirir.
x = arr.join(",");
console.log(x); //32,25,71,51,45

console.log("Önceden : ", arr);
//Diziyi 1.index'ten itibaren(dahil) dizinin sonuna kadar kopyasını döner. Slice metodu orijinal dizide herhangi bir değişiklik meydana getirmez.
x = arr.slice(1); // [ 25, 71, 51, 45 ]
console.log(x);
//Dizinin 1. index'ten itibaren(dahil) dizinin 3. elemanına kadar(hariç) kopyasını döner
x = arr.slice(1, 3); // [ 25, 71 ]
console.log(x);

//Slice metoduyla benzer görevi görür. Fakat slice metodu orijinal dizide değişiklik meydana getirmezken.
//Splice, orijinal diziyi de değiştirir.
//Splice metodu dizideki elemanları çıkarır. Orijinal dizi de değişir.Slice metodundan farkı budur.
x = arr.splice(1, 3);
console.log(x, arr);
