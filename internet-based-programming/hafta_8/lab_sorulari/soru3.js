/*
**Adım 1: Nesne barındıran Diziyi Tanımlama**

`library` adında bir **nesne dizisi** oluştur.

Bu diziye, her biri `title`, `author` ve `status` özelliklerine sahip 3 nesne ekle.

- `title` ve `author` alanları string (metin) türünde olmalı (istediğiniz değerleri atayabilirsiniz).
- `status` alanı ise `own`, `reading` ve `read` şeklinde 3 özelliği olan başka bir nesne olmalı. Yani status tek bir basit değere sahip değil ayrı bir nesne olarak tutulmalıdır. 3 tane de özelliği var.
- Bu 3 özelli **boolean** (true/false) değerler olmalı. Başlangıç tanımlamanızda aşağıdaki gibi olmalı.
    - `own` → `true` olmalı.
    - `reading` ve `read` → `false` olmalı.

---

**Adım 2: Bu kitapları okuduğumuzu göstermek için “okundu(read)” yapıyoruz.**

Tüm kitapları okuduğunu düşünüyoruz. Bu yüzden her kitabın `read` değerini `true` yap.

İlk oluşturduğunuz nesne yapısını değiştirmeyin; değerleri **nokta gösterimi** (dot notation) kullanarak ayarla.

---

**Adım 3: İlk kitabın adını farklı bir değişken adı olarak elde et**

İlk kitaptan (`library[0]`) `title` değerini ayıklama yöntemiyle al ve  değişkenin adını `firstBook` olarak ayarla.

**Adım 4: Tüm veriyi string olarak ekrana bastır**

Son olarak, `library` nesnesini bir **JSON string**'ine dönüştürüp ekrana bastırın
*/

//adım1
const library = [
  {
    title: "The Road Ahead",
    author: "Bill Gates",
    status: {
      own: true,
      reading: true,
      read: false,
    },
  },
  {
    title: "Steve Jobs",
    author: "Walter Isaacson",
    status: {
      own: true,
      reading: false,
      read: false,
    },
  },
  {
    title: "Mockingjay: The Final Book of The Hunger Games",
    author: "Suzanne Collins",
    status: {
      own: true,
      reading: false,
      read: true,
    },
  },
];

//adım2
library[0].status.read = true;
library[1].status.read = true;
library[3].status.read = true;

//adım3
const { title: firstBook } = library[0];
console.log(firstBook);

//adım4
const libraryJSON = JSON.stringify(library);
console.log(libraryJSON);
