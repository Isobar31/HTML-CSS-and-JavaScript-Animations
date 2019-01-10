//Problem: "Write a function which takes in a string and returns counts of each character in the string"
                                  // Breaking down problem to gain vivid solution
function charCount(str)
{
    //make object to return at end.
    var result = {};

    //loop over string, for each character...
    for(var i = 0; i < str.length; i++)
    {
        var char = str[i].toLowerCase();
         //if the char is a number/letter AND is a key in object, add one to count.
         if(/[a-z0-9]/.test(char)) //if char is something else (space, period, etc) don't do anything.
         {
            if(result[char] > 0)
            {
                result[char]++;
            }
            //if the char is a number/letter AND not in object, add it to object and set value to 1.
            else
            {
                result[char] = 1;
            };
         }
    }      
    //return an object with keys that are lowercase alphanumeric charaters in the string
    return result;
}


// The improvement of the same code
function charCount(str)
{
    //make object to return at end.
    var result = {};

    //loop over string, for each character...
    for(var char of str)
    {
        char = char.toLowerCase();
         //if the char is a number/letter AND is a key in object, add one to count.
         if(/[a-z0-9]/.test(char)) //if char is something else (space, period, etc) don't do anything.
         {
            if(result[char] > 0)
            {
                result[char]++;
            }
            //if the char is a number/letter AND not in object, add it to object and set value to 1.
            else
            {
                result[char] = 1;
            };
         }
    }      
    //return an object with keys that are lowercase alphanumeric charaters in the string
    return result;
}


// More improved way of the same function
function charCount(str)
{
    //make object to return at end.
    var result = {};

    //loop over string, for each character...
    for(var char of str)
    {
        char = char.toLowerCase();
         //if the char is a number/letter AND is a key in object, add one to count.
         if(/[a-z0-9]/.test(char)) //if char is something else (space, period, etc) don't do anything.
         {
           result[char] = ++result[char] || 1;
         }
    }      
    //return an object with keys that are lowercase alphanumeric charaters in the string
    return result;
}


// Finally for the sake of time, the fastest code will be considered. Below is the final improvement of the code that works faster.
function charCount(str)
{
    //make object to return at end.
    var result = {};

    //loop over string, for each character...
    for(var char of str)
    {       
         //if the char is a number/letter AND is a key in object, add one to count.
         if(isAlphaNumeric(char)) //if char is something else (space, period, etc) don't do anything.
         {
            char = char.toLowerCase();
           result[char] = ++result[char] || 1;
         }
    }      
    //return an object with keys that are lowercase alphanumeric charaters in the string
    return result;
}

function isAlphaNumeric(char)
{
  var code = char.charCodeAt(0);
  if(
     !(code > 47 && code < 58)  && // (0 - 9)
     !(code > 64 && code < 91)  && // upper alphabet (A-Z)
     !(code > 96 && code < 123) // lower alphabet (a-z)
     )
     {
         return false;
     }
     return true;
}
