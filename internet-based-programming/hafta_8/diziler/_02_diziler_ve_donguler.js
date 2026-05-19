const fruits = ["apple", "banana", "cherry", "date"];

for (let i = 0; i < fruits.length; i++) console.log(`Index ${i}: ${fruits[i]}`);

const fruits = ["elma", "muz", "çilek", "portakal"];

for (let index in fruits) console.log(`Index ${index}: ${fruits[index]}`);

const fruits = ["apple", "banana", "cherry", "date"];
for (let el of fruits) console.log(el);

const fruits = ["apple", "banana", "cherry", "date"];

fruits.forEach((value, index, array) => {
  console.log("value: ", value);
  console.log("value parametresinin aldığı index :", index);
  console.log("array:", array);
});

const fruits = ["apple", "banana", "cherry", "date"];

fruits.forEach((value) => {
  console.log("value: ", value);
});
