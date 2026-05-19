//const arr = [1, 2, 3, 4, 5]; bu diziyi şu hale getirin: [6 , 5 , 4 , 3 , 2 , 1 , 0]

const arr = [1, 2, 3, 4, 5];
//diziyi önce ters çevirelim.
arr.reverse();
console.log(arr);
//dizinin sonuna 0 ekleyelim.
arr.push(0);
console.log(arr);

//dizinin başına 6 ekleyelim.
arr.unshift(6);
console.log(arr);
