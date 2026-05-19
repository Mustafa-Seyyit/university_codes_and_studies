console.log(100);
console.log("Hello World");
console.log(21, "Hello", false);
const x = 100; // Değişken tanımlıyoruz

console.log(x); //değişkenin değerini ekrana bastırıyoruz.

console.error(" Alert Message ");
console.warn(" Uyari/Warning Message");
console.table({ name: "Ahmet Yilmaz", email: "ahmet@gmail.com" });

// Çıktılarımızı gruplayabiliriz.
console.group("My Custom Outputs");
console.log(x);
console.error("Alert Message");
console.warn("Warning Message");
console.groupEnd();

const styles =
  "padding:10px; background-color:green; color:white; font-weight:bold; font-size:12px;";
console.log("%cHello World", styles);
