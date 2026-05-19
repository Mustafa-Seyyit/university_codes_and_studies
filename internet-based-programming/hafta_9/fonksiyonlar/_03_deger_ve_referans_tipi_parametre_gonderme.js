const flight = "231231";

const ahmet = {
  name: "Ahmet Yilmaz",
  passport: 1111111111,
};

const checkIn = (flightNum, passenger) => {
  //parametre olarak gelen flightNum ve passenger değerlerini değiştirelim.
  flightNum = "AB24123";
  passenger.name = `Mr. ` + passenger.name;

  if (passenger.passport === 1111111111)
    console.log("Checked in ", passenger.name);
  else console.log("Wrong Passport");
};

checkIn(flight, ahmet);

//Bakalım fonksiyon çalıştıktan sonra kendisine gönderdiğimiz 2 parametre olan
//flight ve ahmet değişkenlerinde bir değişiklik var mı?
console.log(`Flight: ${flight}`); //231231 (Yani değişiklik yok. Çünkü fonksiyon içinde AB24123 atamıştık)
console.log(ahmet); //{ name: 'Mr. Ahmet Yilmaz', passport: 1111111111 } => Değişiklik var. name özelliği Mr ile başlıyor.
