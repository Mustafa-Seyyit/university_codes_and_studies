let age = 20;
let name = null;

// Karşılaştırma
if (age >= 18) {
  console.log("Reşit");
}

// Mantıksal VE
if (age > 18 && age < 30) {
  console.log("Genç yetişkin");
}

// Mantıksal VEYA
if (age < 18 || age > 65) {
  console.log("İndirimli bilet");
}

//name truthy bir değere sahipse VE age 18'den büyükse
//name falsy bir değer olan null olduğu için koşul false olacaktır
if (name && age > 18) console.log("Giriş Başarılı");
else console.log("Giriş Başarısız");

const d = new Date(2025, 11, 30, 6, 0, 0); // 30.12.2025 09:00:00
const hour = d.getHours();

// Nested If (iç içe if deyimleri)
if (hour < 12) {
  console.log("Good Morning");

  if (hour === 6) {
    console.log("Nazif Uyan! Sınava Geç Kaldın.");
  }
} else if (hour < 18) {
  console.log("Good Afternoon");
} else {
  console.log("Good Night");
}

if (hour >= 20) {
  console.log("zzzzzzzz");
}

//boş bir objeyi kontrol etme
const user = {};
if (user) console.log("List User");
else console.log("No User");

if (Object.keys(user).length) console.log("List User");
else console.log("No User");

const day = "Saturday";

switch (day.toLowerCase()) {
  case "monday":
  case "tuesday":
  case "wednesday":
  case "thursday":
  case "friday":
    console.log(`${day} is a weekday.`);
    break;

  case "saturday":
  case "sunday":
    console.log(`${day} is a weekend.`);
    break;

  default:
    console.log("Invalid day!");
}

koşul ? doğruysa_calistir : yanlissa_calistir;

const age = 19;

const canVote = age >= 18 ? "Oy kullanabilir" : "Oy kullanamaz";
console.log(canVote); // "Oy kullanabilir"

const score = 72;

const grade =
  score >= 90
    ? "A"
    : score >= 80
      ? "B"
      : score >= 70
        ? "C"
        : score >= 60
          ? "D"
          : "F";

console.log(`Notunuz: ${grade}`); // Notunuz: C

let auth = true;
auth ? console.log("Welcome to the Dashboard") : null;
