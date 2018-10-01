var car = {color: "green", make: "Sanyang", model: 501};
car.color = "blue";
console.log(car);

// we can manipulate the following in the console of the browser in order to make changes in the object.
car["color"] = "black"; // changes the color.
delete car.color // deletes the color property of the object.
