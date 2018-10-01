var task = ["do assignment", "take a sport", "cook", "read", "meet with friends", "wash film"];
alert(" \"1 = do assignment.\" \"2 = take a sport.\" \"3 = cook.\" \"4 = read.\" \"5 = meet with friends\", \"6 = meet with friends\"");
var question = prompt("What would you like to do now from the above list?");

alert("Thank you for answering. So you would like to " + task[(question - 1)]);
alert("The last element of the array is " + task[(task.length -1)]);//to show the last element of the array.
//Checking if task and task[2] are array.
console.log(Array.isArray(task));
console.log(Array.isArray(task[2]));
