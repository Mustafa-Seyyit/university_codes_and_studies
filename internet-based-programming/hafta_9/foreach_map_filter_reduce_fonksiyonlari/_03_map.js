//Örnek-1: Basit bir sayı dizisindeki tüm elemanların 3 katını alan bir örneği forEach ile yapmıştık bunun aynısı map metoduyla yapalım.
const numbers = [1, 2, 3, 4, 5, 6];

const r1 = [];
numbers.forEach((n1) => r1.push(n1 * 3));

console.log(r1);

//Şimdi de aynı işlemi map metoduyla yapalım
const r2 = numbers.map((n1) => n1 * 3);
console.log(r2);
/*
Sonuç:  foreach metodu bir dizi döndürmediği için önceden bir dizi oluşturduk ve push
metoduyla foreach metodunun içinde ekleme yaptık. Fakat map metodu zaten kendi içinde
return edilen değerleri otomatik olarak bir diziye atıyor ve bunu da eşitliğin sol tarafındaki
değişkene aktarıyor. Sonuç olarak r1 ve r2 dizilerinde aynı değer var.
*/

//Örnek-2: Basit Şirketleri tutan bir obje dizisindeki şirket bilgilerinden sadece isimlerini alıp bir diziye aktaralım.
const companies = [
  { name: "Company One", category: "Finance", start: 1981, end: 2004 },
  { name: "Company Two", category: "Retail", start: 1992, end: 2008 },
  { name: "Company Three", category: "Auto", start: 1999, end: 2007 },
  { name: "Company Four", category: "Retail", start: 1989, end: 2010 },
  { name: "Company Five", category: "Technology", start: 2009, end: 2014 },
  { name: "Company Six", category: "Finance", start: 1987, end: 2010 },
  { name: "Company Seven", category: "Auto", start: 1986, end: 1996 },
  { name: "Company Eight", category: "Technology", start: 2011, end: 2016 },
  { name: "Company Nine", category: "Retail", start: 1981, end: 1989 },
];

//Şirket bilgilerinden sadece isimlerini tutan bir dizi alalım. Yani tüm şirketlerin isimlerini alalım
const companyNames = companies.map((c1) => c1.name);
console.log(companyNames);

//Bu sefer şirket adlarını hem de kategorilerini obje olarak diziye atalım
const companyInfo = companies.map((c1) => {
  return {
    name: c1.name,
    category: c1.category,
  };
});

console.log(companyInfo);
