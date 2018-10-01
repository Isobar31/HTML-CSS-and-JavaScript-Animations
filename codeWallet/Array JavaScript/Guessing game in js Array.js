var animal = new Array("dog", "sheep", "goat", "camel", "cat", "rabbit", "monkey");
var randomIndex = Math.floor(Math.random()*animal.length);
var randomAnimal = animal[randomIndex];

var message = prompt("Which animal value is "+ randomAnimal + "?");
var response = (message == randomIndex)? "Correct!" : "Wrong, it is "+ randomIndex;
alert(response);
