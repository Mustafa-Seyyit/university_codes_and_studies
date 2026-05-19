/*
2 tane dizi düşünelim. Bu iki dizinin her ikisinde de 5 elemanı ortak olarak bulunsun. Bu iki diziyi birleştirdikten sonra fazladan olan 5 elemanında kurtularak birleştirmelisiniz.

const arr1 = [1, 2, 3, 4, 5];
const arr2 = [5, 6, 7, 8, 8, 9, 10];

Birleştirme sonucu:  [1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10] olmalı. Çözümün çok farklı yolları var. Gördüğümüz metotları kullanarak istediğiniz yöntemi kullanabilirsiniz. 
*/

const arr1 = [1, 2, 3, 4, 5];
const arr2 = [5, 6, 7, 8, 8, 9, 10];

const finalArray = [...arr1, ...arr2];
console.log(finalArray);

//splice metoduna silinecek değerin indexi olarak 5 elemanının index'ini bularak yolluyoruz. Ayrıca splice metoduna 2. parametre olarak kaç tane değeri silmesi gerektiğini belirtmek için 1 yolluyoruz.
finalArray.splice(finalArray.indexOf(5), 1);
console.log(finalArray);
