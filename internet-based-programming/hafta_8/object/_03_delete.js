const person = {
  name: "Ahmet Yilmaz",
  age: 60,
  isAdmin: true,
  address: {
    street: "123 Main St",
    city: "Boston",
    state: "Siirt",
  },
  hobbies: ["music", "sports"],
};

console.log(person);

delete person.isAdmin;
console.log(person);
