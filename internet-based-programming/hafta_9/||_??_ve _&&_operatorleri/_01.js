console.log("Merhaba" || "Dünya"); //  "Merhaba" (çünkü ilk değer truthy)
console.log(0 || 42); //  42 (çünkü 0 falsy)
console.log("" || "Boş değil"); //  "Boş değil"
console.log(null || "Varsayılan"); //  "Varsayılan"

b = 10 || 20;
console.log(b); //10

//Hiçbiri truthy değil o zaman sondaki değeri döner
b = 0 || null || "" || undefined;
console.log(b);

b = false || undefined || 12 || ""; // 12 truthy değer
console.log(b);

let age = userInputAge ?? 18;

console.log(null ?? "Varsayılan"); // "Varsayılan"
console.log(undefined ?? "Yedek"); //  "Yedek"
console.log(0 ?? 99); // 0
console.log(false ?? true); // false
console.log("" ?? "Boş değil"); //  ""

let a = 0;
let b = null;
let c = undefined;
let d = false;
let e = "";

console.log(a || 10); // 10  çünkü 0 falsy
console.log(a ?? 10); // 0   çünkü sadece null/undefined değil

console.log(b || 20); // 20  çünkü null falsy
console.log(b ?? 20); // 20  çünkü null

console.log(c || 30); // 30  çünkü undefined falsy
console.log(c ?? 30); // 30  çünkü undefined

console.log(d || 40); // 40   çünkü false falsy
console.log(d ?? 40); // false çünkü false null/undefined değil

console.log(e || "empty"); // "empty"  çünkü "" falsy
console.log(e ?? "empty"); // ""       çünkü boş string null/undefined değil

let v1;
v1 = true && "Merhaba"; //Merhaba
console.log(v1);

v1 = false && "Merhaba"; // false
console.log(v1);

v1 = 1 && 5; // 5 (Çünkü soldaki 1 truthy'dir)
console.log(v1);

v1 = 0 && 5; // 0 (Çünkü soldaki 0 falsy'dir)
console.log(v1);

//Rastgele 0-1 üretiyoruz. Onu da boolean'a dönüştürerek true veya false üretmiş oluyoruz
let isLoggedIn = Boolean(Math.floor(Math.random() * 2));
const message = isLoggedIn && "Hoş geldin!";
console.log(message); //  "Hoş geldin!"

let val = 0;

val || 10; //10     (çünkü 0 falsy)
val && 10; //0      (ilk falsy değer)
val ?? 10; //0      (0 null/undefined değil)

val = null;

val || "X"; //"X"
val && "X"; //null
val ?? "X"; //"X"

val = "hello";

val || "X"; //"hello"
val && "X"; //"X"
val ?? "X"; //"hello"

const user = {
  username: "", // boş string
  isLoggedIn: true, // giriş yapmış
  isPremium: false, // premium değil
};

// ?? → username  null/undefined ise "Misafir" yaz değilse o değer neyse onu yaz.
const displayName = user.username ?? "Misafir";

// || → isPremium false olduğu için reklam gösterilsin
const showAds = !user.isPremium || "Reklam gösterme";

// && → giriş yapılmışsa profilini göster
const profileSection = user.isLoggedIn && "Profil Sayfası";

// Ekrana yazdıralım:
console.log("Kullanıcı adı:", displayName); // "" (çünkü boş string null/undefined değil)
console.log("Reklam durumu:", showAds); // true  → reklam gösterilsin
console.log("Gösterilecek içerik:", profileSection); // "Profil Sayfası"
