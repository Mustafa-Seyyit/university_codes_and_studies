console.log("ahmet", false, true, 1, 3, 4, 5, 6, 7, [10, 20, 30, true, false]);
let max1 = Math.max(1, 2, 3, 4, 5, 6, 7, 8, 99);
let min1 = Math.min(1, 2, 3, 4, 5, 6, 7, 8, 99);
console.log(min1, max1);

function sum1(...numbers) {
  let sum = 0;
  for (let i = 0; i < numbers.length; i++) sum += numbers[i];
  return sum;
}

let result = sum1(10, 5, 3);
console.log(result);
result = sum1(10, 20, 30, 40, 50, 60);
console.log(result);
