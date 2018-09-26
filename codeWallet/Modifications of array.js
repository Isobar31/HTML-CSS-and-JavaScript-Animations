var animals = new Array("dog", "sheep", "goat", "camel", "cat", "rabbit", "monkey");

animals.push("lion", "antelope");//adds item at the end of the array.
animals.pop();//removes item at the end of array.
var remove1 = animals.pop(); //the item removed is stored in a variable.
console.log(remove1);

animals.shift();//removes first item from array.
animals.unshift("donkey");//Adds first item to array.

console.log(animals);

var lastRemove = animals.splice(4, 3);//removes 3 items from position 4.
console.log(animals);

console.log(lastRemove);//the elements removed.

animals.reverse();//reverses the order of items.
animals.sort();//sorts items by value.

console.log(animals);//Now see the ordered array.
animals.reverse();
console.log(animals);

animals.sort().reverse();//You can also sort and reverse them at the same time, you will still have the same result.
console.log(animals);

animals[35] = "buffalo";//The other spaces are filled with undefined.
animals.fill("still wild animal", 4, 32);//fill 32 positions with "still wild animal" from the 4th position.
animals.fill("still wild animal", 4, (animals.length-1));//same as the above but more dynamic.

//The filling can also dynamically be done as below.
var animals = new Array("dog", "sheep", "goat", "camel", "cat", "rabbit", "monkey");
var startVal = animals.length;
animals[26] = "buffalo";
animals.fill("still wild animal", startVal, (animals.length-1));
console.log(animals);
