const greet = function (name) {
  return `Hello, ${name}`;
};

console.log(greet("Ahmet")); // Hello, Ahmet

//Örnek 1: Callback kullanan higher-order function
function processUserInput(callback) {
  const name = "Ahmet";
  callback(name);
}

processUserInput(function (name) {
  console.log("Hello " + name);
});

// Örnek 2: Fonksiyon döndüren higher-order function
function multiplier(factor) {
  return function (number) {
    return number * factor;
  };
}

const double = multiplier(2);
console.log(double(5)); // 10

//fonksiyonu parametre olarak alabilir
const greet = () => console.log("Hello");
button.addEventListener("click", greet);

//fonksiyon döndürebilir

function multiplier(factor) {
  return function (num) {
    return num * factor;
  };
}

const ikiKati = multiplier(2);
const ucKati = multiplier(3);

console.log(ikiKati(4)); // 8 (4*2)
console.log(ucKati(4)); // 12 (4*3)

const greet = (greeting) => {
  //fonksiyon oluşturup döndürüyoruz.
  return function (name) {
    console.log(`${greeting} ${name}`);
  };
};

//Kişiyi Merhaba ve Hey ifadesiyle karşılayan fonksiyonlar
const greeterMerhaba = greet("Merhaba");
const greeterHey = greet("Hey");

greeterMerhaba("Ahmet Yılmaz");
greeterHey("Selin Yıldırım");

const oneWord = (str) => {
  return str.replace(/ /g, "").toLowerCase();
};

const upperFirstWord = (str) => {
  const [first, ...others] = str.split(" ");
  return [first.toUpperCase(), ...others].join(" ");
};

const transformer = (str, fn) => {
  //gönderlen str parametresine, 2. parametredeki fonksiyonu uygula
  console.log("---------------");
  console.log(`Original String :${str}`);
  console.log(`Transformed String: ${fn(str)}`);
  console.log(`Transformed by: ${fn.name}`);
  console.log("---------------");
};

transformer("Javascript is the best!", upperFirstWord);
transformer("Javascript is the best!", oneWord);
