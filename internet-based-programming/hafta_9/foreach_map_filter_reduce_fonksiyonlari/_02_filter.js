//Örnek-1: Kullanıcıların listesinden aktif olanların filtrelenmesi.
const users = [
  { fullName: "Ahmet Yılmaz", isActive: true },
  { fullName: "Mehmet Veli", isActive: false },
  { fullName: "Ali Duran", isActive: true },
  { fullName: "Oğuz Şahin", isActive: false },
];

//Aktif kullanıcıların listesini alalım
const acitveUsers = users.filter((user) => user.isActive);
console.log(acitveUsers);

console.log("-------------------------");
//Aktif olmayan kullanıcıların lisetsini alalım
const inactiveUsers = users.filter((user) => !user.isActive);
console.log(inactiveUsers);

//Örnek-2: Şirketlerin verileriyle alakalı filtreleme işlemleri
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

// Sadece retail şirketlerini al
const retailCompanies = companies.filter(
  (company) => company.category === "Retail",
);
console.log(retailCompanies);

//Belirli yıllar arasında kurulmuş şirketleri al
const earlyCompanies = companies.filter(
  (company) => company.start >= 1980 && company.end <= 2005,
);
console.log(earlyCompanies);
