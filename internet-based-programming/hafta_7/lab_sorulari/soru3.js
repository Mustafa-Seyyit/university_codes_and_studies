const job = "developer";
let myNewJob;
//Çözüm: İlk harfi al ve büyüt. Sonra geri kalan ifadeyi de sonuna ekle
myNewJob = job.charAt(0).toUpperCase() + job.substring(1);
//veya
myNewJob = job[0].toUpperCase() + job.slice(1);
console.log(myNewJob); //Developer çıktısını üretmeli
