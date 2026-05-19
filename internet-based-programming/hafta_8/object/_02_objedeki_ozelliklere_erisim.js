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

let x;

//nesne.ozellikAdi şeklinde erişelim.
x = person.name;
console.log(x); //Ahmet Yilmaz

//nesne["ozellikAdi"] şeklinde erişelim.
x = person["age"];
console.log(x); // 60

console.log(person["firstName"]);
console.log(person["firstName"] == undefined ? "Field yok" : "Field Var");

//address içindeki city özelliğine erişelim.
x = person.address.city;
console.log(x); //boston

x = person["address"].city;
console.log(x);

x = person["address"]["city"];
console.log(x);

let firstHobby = person.hobbies[0];
console.log(firstHobby);

console.log(person.name); //Ahmet Yılmaz
person.name = "Mehmet Yılmaz";
console.log(person.name); //Mehmet Yılmaz

person.isAdmin = false;
console.log(person.isAdmin); //false
