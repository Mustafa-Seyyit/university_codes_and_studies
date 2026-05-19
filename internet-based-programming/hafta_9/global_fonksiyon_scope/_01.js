var globalDegisken = 5; //gloabal scope da tanımlı

function fonksiyon1() {
  console.log("global değişkenin değeri: " + globalDegisken);
  var localDegisken = 10; //local scope da tanımlı
  console.log("local değişkenin değeri: " + localDegisken);
}
fonksiyon1();

const x = 100;
console.log(x, " in global"); //100

function run() {
  console.log("run fonksiyonu çalıştı");
  console.log(x, " in function"); // 100 Gelir
}
run();

if (true) console.log(x, " in block"); //100 => globaldeki x'e erişir.

function add() {
  const x = 1; //yeniden bir x değişkeni tanımladık.
  const y = 50;
  console.log(x + y); //51 (localde olan x değişkeni kullanılır)
}

add();

console.log(x, " in global"); // x yine 100
