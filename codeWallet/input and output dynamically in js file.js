var task = ["do assignment", "take a sport", "cook", "read", "meet with friends"];
alert(" \"1 = do assignment.\" \"2 = take a sport.\" \"3 = cook.\" \"4 = read.\" \"5 = meet with friends\"");
var question = prompt("What would you like to do now from the above list?");

alert("Thank you for answering. So you would like to " + task[(question - 1)]);
