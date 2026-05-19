const todo = new Object();

//buna özellikler ve değerler ekleyelim.
todo.id = 1;
todo.name = "Buy Milk";
todo.completed = false;

console.log(todo);

const obj1 = { a: 1, b: 2 };
const obj2 = { c: 3, d: 4 };

//2 objeyi birleştirelim.
const resultObject = { obj1, obj2 };
console.log(resultObject);

console.log(resultObject.obj1);
console.log(resultObject.obj2);

console.log(resultObject.obj1.a, resultObject.obj1.b);
console.log(resultObject.obj2.c, resultObject.obj2.d);

const resultObject2 = { ...obj1, ...obj2 };
console.log(resultObject2);

const resultObject3 = Object.assign({}, obj1, obj2);
console.log(resultObject3);

const todos = [
  { id: 1, name: "Buy Milk", done: false },
  { id: 2, name: "Pick up kids from school", done: true },
  { id: 3, name: "Take out trash", done: false },
];

for (let todo of todos) console.log(todo.name);

Object.keys(nesneAdi);

console.log(Object.keys(todos[0]));

console.log(Object.values(todos[0])); //[ 1, 'Buy Milk', false ]
console.log(Object.values(todos[1])); //[ 2, 'Pick up kids from school', true ]

const todo = new Object();

todo.id = 1;
todo.name = "Buy Milk";
todo.completed = false;

console.log(`todo nesnesinde ${Object.keys(todo).length} tane key var`);

const todo = new Object();

//buna özellikler ve değerler ekleyelim.
todo.id = 1;
todo.name = "Buy Milk";
todo.completed = false;

console.log(Object.entries(todo));

todo.id = 1;
todo.name = "Buy Milk";
todo.completed = false;

console.log(todo.hasOwnProperty("name")); //true
console.log(todo.hasOwnProperty("isDone")); // false
