const animals = ["cat", "dog", "bird", "horse"];

animals.forEach((value, index, array) => {
  //Sadece bir kere bastıralım ekrana
  if (index == 0) console.log(array);
  console.log(`array[${index}] = ${value}`);
});

const movements = [200, 450, -400, 3000, -650, -130, 70, 1300];
//eğer değer pozitifse para yatırma anlamına geliyor.
//negatifse para çekiliyor anlamına geliyor.

for (const movement of movements)
  if (movement > 0) console.log(`You deposited ${movement}`);
  else console.log(`You withdraw ${Math.abs(movement)}`);

console.log("------------------------");
//Aynı işi foreach ile yapalım
movements.forEach((movement) => {
  if (movement > 0) console.log(`You deposited ${movement}`);
  else console.log(`You withdraw ${Math.abs(movement)}`);
});

//Bir dizideki değerlerin 3 katını alıp yeni bir dizide oluşturur. Ayrıca dizideki tek elemanları ayrı bir dizide oluştur.
const numbers = [5, 10, 20, 15, 30];
const newArray = [];

numbers.forEach((n1) => newArray.push(n1 * 3));
console.log(newArray); //[ 15, 30, 60, 45, 90 ]

const oddNumbers = [];
numbers.forEach((n1) => {
  if (n1 % 2 == 1) oddNumbers.push(n1);
});
console.log(oddNumbers); //[ 5, 15 ]

//objelerle çalışma
const socialObjs = [
  { name: "Twitter", url: "https://twitter.com" },
  { name: "Facebook", url: "https://facebook.com" },
  { name: "Linkedin", url: "https://linkedin.com" },
  { name: "Instagram", url: "https://instagram.com" },
];

socialObjs.forEach((item) => console.log(item.url));
