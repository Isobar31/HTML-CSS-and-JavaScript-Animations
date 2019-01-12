//Problem: Given two strings, write a function to determine if the 2nd string is an anagram of the 1st (e.g cinema == iceman). 

function AnagramStrings(str1, str2)
{   
    if(str1 !== str2)
    {        
       return false;
    }
     
  const loopUp = {};

for(var i = 0; i < str1.length; i++)
{
    var letter = str1[i];
    loopUp[letter] ? loopUp[letter] += 1 : loopUp[letter] = 1;
}
console.log(loopUp);

for(var i = 0; i < str2.length; i++)
{
    var letter = str2[i];
    if(!loopUp[letter])
    {
        return false;
    }
    else
    {
        loopUp[letter] -= 1;
    }
}
 return true;
}

