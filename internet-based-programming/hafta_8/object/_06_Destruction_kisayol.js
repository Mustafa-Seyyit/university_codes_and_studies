const todo = { id: 3, name: "Take out trash", done: false };

const id = todo.id;
const done = todo.done;
console.log(id, done); //3 false

const { id, done } = todo;
console.log(id, done); //3 false

const todo = {
  id: 3,
  name: "Take out trash",
  done: false,
  user: { name: "Ahmet Yilmaz", age: 50, isMarried: true },
};

const { id, done, user } = todo;
console.log(id, done, user);

const { name: title } = todo;
console.log(title);

const {
  id,
  done,
  user: { age },
} = todo;
console.log(id, done, age); //3 false 50

const numbers = [10, 20, 30, 40, 50];

const [firstNumber, secondNumber] = numbers;
console.log(firstNumber, secondNumber); // 10 20

const [firstNumber, secondNumber, ...rest] = numbers;
console.log(rest); // [ 30, 40, 50 ]

const [, , ...rest] = numbers;
console.log(rest); // [ 30, 40, 50 ]
