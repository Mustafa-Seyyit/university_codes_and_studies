//Örnek-1: Bir dizideki sayıları reduce metoduyla kümülatif olarak toplayalım.
const numbers = [2, 4, 6, 8];
const r1 = numbers.reduce((accumulator, currentValue) => {
  return accumulator + currentValue;
}, 0);

console.log(r1);

/*
Örnek-2: Bir kitap dizisinde hangi kitaptan kaç tane olduğunu bulalım. Burada amaç reduce
fonksiyonu ile dizilerde gruplama yapabilir ve sonucu nesne olarak dönebiliriz
*/
let books = [
  "javascript",
  "javascript",
  "clojure",
  "clojure",
  "clojure",
  "java",
  "kotlin",
  "kotlin",
];
const firstValue = {};
const reducer = function (obj, count) {
  if (!obj[count]) {
    //Daha önce bu kitap yer aldı mı nesnemde? yoksa 1 yap varsa var olan adet sayısını 1 arttır.
    obj[count] = 1;
  } else {
    obj[count] = obj[count] + 1;
  }
  return obj;
};
const result = books.reduce(reducer, firstValue);
console.log("Kitaplar ve Adetleri: ", result);
