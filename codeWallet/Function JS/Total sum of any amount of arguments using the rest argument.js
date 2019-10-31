const sum = (...args) => {
  let total = 0;
  for(const n of args){
     total += n;
  }
  return total;
}
console.log(sum(1, 2, 3, 8, 4)); // 6
