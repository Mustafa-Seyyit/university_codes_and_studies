//Örnek-1: Çarpım tablosunu yazdırır. 1x1’den 10x10’a kadar
for (let i = 1; i <= 10; i++) {
  console.log(`Number : ${i}`);
  for (let j = 1; j <= 10; j++) console.log(`${i} x ${j} = ${i * j}`);
}

/* 
**Örnek-2:**

- Her öğrenci için adı ve notu ekrana yazdırılır.
- `total` değişkenine her öğrencinin notu eklenir.
- Döngüden sonra ortalama hesaplanıp gösterilir.
*/
const students = [
  { name: "Ahmet", grade: 70 },
  { name: "Zeynep", grade: 85 },
  { name: "Mehmet", grade: 90 },
  { name: "Elif", grade: 60 },
];

let total = 0;

for (let i = 0; i < students.length; i++) {
  console.log(`${students[i].name} adlı öğrencinin notu: ${students[i].grade}`);
  total += students[i].grade;
}

const average = total / students.length;
console.log(`Sınıf ortalaması: ${average}`);

for (const student of students) {
  console.log(`${student.name} adlı öğrencinin notu: ${student.grade}`);
  total += student.grade;
}

const name = "Ahmet Yılmaz";
for (const letter of name) console.log(letter);

//Nesnenin içindeki her bir özelliğini teker teker ekrana yazdıralım
const colorObj = {
  color1: "red",
  color2: "blue",
  color3: "orange",
  color4: "green",
};

for (const key in colorObj) console.log(key, colorObj[key]);

//Dizilerde kullanabiliriz. Dizinin her bir elemanını ekrana yazdıralım
const colorArr = ["red", "green", "blue", "yellow"];

for (const key in colorArr) console.log(colorArr[key]);

const students = [
  { name: "Ahmet", grade: 70 },
  { name: "Zeynep", grade: 85 },
  { name: "Mehmet", grade: 90 },
  { name: "Elif", grade: 60 },
];

let total = 0;
let i = 0;

while (i < students.length) {
  console.log(`${students[i].name} adlı öğrencinin notu: ${students[i].grade}`);
  total += students[i].grade;
  i++;
}

const average = total / students.length;
console.log(`Sınıf ortalaması: ${average}`);

//Örnek-1 : Bir dizide negatif değer olup olmadğını bulan kod
const numbers = [1, 2, 3, -1, 4, 5, 0];
let hasNegative = false;

for (const n1 of numbers)
  if (n1 < 0) {
    hasNegative = true;
    break;
  }

if (hasNegative) console.log("Negatif Sayı Var");
else console.log("Negatif Sayı Yok");

//Örnek-2 : Eksi not alan öğrencileri atlayarak sadece geçerli notları yazdır
const students = [
  { name: "Ahmet", grade: 70 },
  { name: "Zeynep", grade: -1 }, // geçersiz
  { name: "Mehmet", grade: 85 },
  { name: "Elif", grade: -1 }, // geçersiz
  { name: "Ali", grade: 90 },
];

for (let i = 0; i < students.length; i++) {
  if (students[i].grade < 0) continue;

  console.log(
    `${students[i].name} adlı öğrencinin geçerli notu: ${students[i].grade}`,
  );
}
