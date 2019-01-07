var date = new Date();
document.write(date + "<br>");

var getYear = date.getFullYear();
document.write(getYear + "<br>");

var now = date.getMonth(); /*You can check the JS Date built-in methods 
                            for date in JavaScript Date MSDN online 
                            and play with them all. */
document.write(now + "<br>");


var d = new Date();

var day = d.getDay();
switch (new Date().getDay()) 
{
    case 0:
      day = "Sunday";
      break;
    case 1:
      day = "Monday";
      break;
    case 2:
       day = "Tuesday";
      break;
    case 3:
      day = "Wednesday";
      break;
    case 4:
      day = "Thursday";
      break;
    case 5:
      day = "Friday";
      break;
    case 6:
      day = "Saturday";
  }
document.write(day + "<br>");

var hour = d.getHours();
document.write(hour + " hour <br>");

var seconds = d.getSeconds();
document.write(seconds + "<br>");
