var myArray = ["Number", 100, "False"]; //Literal array storing different data types
var array3 = []; //initializing array with no default value.

var myArray2 = new Array(20, "myself", "I", "you"); //object array. This is the most used array initialization.
var array4 = new Array(); //initializing array with no default value.
console.log(myArray);
myArray[2];

//Updating an existing array.
myArray[0] = 50;
console.log(myArray);


//Random with array
var myArray = new Array("school", "game", "work", "family", "faith");
var rnd = Math.random();
var fin = Math.floor(rnd*myArray.length);
console.log(fin);
//
