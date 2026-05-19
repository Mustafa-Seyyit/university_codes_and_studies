const bookings = [];

const createBooking = (flightNum, numPassengers, price) => {
  numPassengers = numPassengers || 1;
  price = price || 200;

  //Parametre olarak gönderilen değerlerden  bir booking objesi oluşturuyoruz.
  const booking = {
    flightNum,
    numPassengers,
    price,
  };

  //Ekrana kaydedilecek olan booking'i yazdırıyoruz
  console.log(booking);

  //diziye kaydediyoruz
  bookings.push(booking);
};

createBooking("LH123", 12, 2500);

//numPassengers ve price'a parametre göndermiyoruz
createBooking("LH123");

const createBooking = (flightNum, numPassengers = 1, price = 200) => {
  //Parametre olarak gönderilen değerlerden  bir booking objesi oluşturuyoruz.
  const booking = {
    flightNum,
    numPassengers,
    price,
  };

  //Ekrana kaydedilecek olan booking'i yazdırıyoruz
  console.log(booking);

  //diziye kaydediyoruz
  bookings.push(booking);
};

createBooking("LH123", 2); //Yolcu sayısı 2 fakat ücreti girmedik
createBooking("LH123", undefined);
createBooking("LH123", undefined, undefined);
createBooking("LH123", null, null); //null gönderdiğimiz için
