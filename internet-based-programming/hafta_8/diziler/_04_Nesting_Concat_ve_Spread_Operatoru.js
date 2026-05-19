let x;

const fruits = ["apple", "pear", "orange"];
const berries = ["strawberry", "blueberry", "rasberry"];

console.log("Öncesi (fruits) : ", fruits);
//push metodu tahmin edeceğinizin aksine berries dizisinin her bir elemanını fruits dizisinin sonuna eklemez.
//push metodu burada berries dizisini tek bir parça halinde fruits dizisinin sonuna ekler
fruits.push(berries);
//fruits dizisinin son elemanı berries dizisi olur.
console.log("Sonrası (fruits) : ", fruits);

//3. indexteki dizinin 2. index’indeki elemana erişelim.
console.log(fruits[3][2]); //rasberry

let x;

const fruits = ["apple", "pear", "orange"];
const berries = ["strawberry", "blueberry", "rasberry"];

//allFruits dizisi 2 elemanlı olur. Birinci eleman fruits dizisi, 2. eleman berries dizisi
let allFruits = [fruits, berries];
console.log(allFruits);

let firstArray = allFruits[0];
console.log(firstArray);

let v1 = allFruits[0][2];
console.log(v1); //orange

let allFruits = [...fruits, ...berries];

let x;

const fruits = ["apple", "pear", "orange"];
const berries = ["strawberry", "blueberry", "rasberry"];

let allFruits = [...fruits, ...berries];
console.log(allFruits);

const fruits = ["apple", "pear", "orange", ["Another", "fruits", "array"]];
const berries = ["strawberry", "blueberry", "rasberry"];

let allFruits = [...fruits, ...berries];
console.log(allFruits);

let allFruits2 = fruits.concat(berries);

let x;

const fruits = ["apple", "pear", "orange"];
const berries = ["strawberry", "blueberry", "rasberry"];

let allFruits = [...fruits, ...berries];
console.log(allFruits);

let allFruits2 = fruits.concat(berries);
console.log(allFruits2);

const arr1 = [0, 1, 2, [3, 4]];
console.log(arr1.flat()); //[0, 1, 2, 3, 4]

const arr2 = [0, 1, 2, [90, [[3, 4]]]];
console.log(arr2.flat()); //çıktısı: [ 0, 1, 2, 90, [ [ 3, 4 ] ] ] (1. Dereceye kadar Düzleştirme)
console.log(arr2.flat(2)); //çıktısı: [ 0, 1, 2, 90, [ 3, 4 ] ] (2. Dereceye kadar Düzleştirme)
console.log(arr2.flat(3)); //çıktısı: [0, 1, 2, 90, 3, 4 ] (3. Dereceye kadar düzleştirme)

const numbers = [10, 20, 5, 24, 61, 19];

console.log(Array.isArray(numbers)); //true
console.log(Array.isArray(1)); //false
console.log(Array.isArray([1])); //true
console.log(Array.isArray([false, "Ahmet"])); //true

console.log(Array.from("Ahmet"));
console.log(Array.from("123456"));
