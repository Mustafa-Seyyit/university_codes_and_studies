//STRİNG

let firstName = "Ahmet";
let message = "Merhaba";
let info = `Name: ${firstName}`;

//NUMBER

let age = 30;
let temperature = 22.5;

//BOOLEAN

let isActive = true;
let isPasswordAvailable = false;

//NULL

let selectedProduct = null; // Şu an bir şey seçilmedi

console.log(null == undefined); //true    == => eşit sayar
console.log(null === undefined); //false   === =>Tipleri farklı olduğu için ayırır.

//SYMBOL

let id1 = Symbol("ahmet");
let id2 = Symbol("ahmet");
console.log(id1 == id2); //false verir.

constkey1 = Symbol("id");
constkey2 = Symbol("id");

constobj = {
  [key1]: 1,
  [key2]: 2,
};

console.log(obj[key1]); // 1
console.log(obj[key2]); // 2

//BIGINT

let bigNumber = 1234567890123456789012345678901234567890n;

// Referans Tipli Değişkenler

const arr1 = [1, 2, 3, 4, 5];
const arr2 = arr1;
arr2[0] = 10;
console.log(arr1);
console.log(arr2);

const user1 = { name: "Ahmet" };
const user2 = user1;

user2.name = "Mehmet";

console.log(user1.name); // "Mehmet"
console.log(user1);
console.log(user2);

//Statik Tip vs Dynamic Tip

let x = 5; // JavaScript x'in bir sayı olduğunu otomatik algılar
x = "Merhaba"; // x artık bir metin oldu  yani tipi değişti ama sorun olmaz.

//Primitive vs Referans Tip

let name = "John";
let age = 40;

let person = {
  name: "Brad",
  age: 50,
};

//Eşitlesek bile primitive tipler stack'te farklı alanlarda tutulurlar.
//yani newName veya name değişkenlerinden birinde yapılacak değişiklik diğerini etkilemez.
let newName = name;
console.log(newName, name); // John John
newName = "Jonathan";
console.log(newName, name); // Jonathan John (Sadece newName değişti)

let newPerson = person; //newPerson ve person heap'te aynı alanı referans gösterirler.

console.log(newPerson.name, newPerson.name); //Brad Brad
newPerson.name = "Bradley";
console.log(newPerson.name, newPerson.name); //Bradley Bradley (İkisi için de Bradley)
