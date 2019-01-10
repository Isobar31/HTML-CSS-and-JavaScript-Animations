/* Problem: Write a function called same, which accepts 2 arrays. The function should retuen true if every value of the array has 
its corresponding value squared in the second array. The frequency of value must be the same.
*/

//          A Naive Solution (Not the best solution) this gives O(n^2) time complexity.
function same(arr1, arr2)
{
    if(arr1.length !== arr2.length)
    {
        return false;
    }

    for(var i = 0; i < arr1.length; i++)
    {
        var correctIndex = arr2.indexOf(arr1[i]**2);
        if(correctIndex === -1)
        {
            return false;
        }
        arr2.splice(correctIndex, 1)
        return true;
    }
}


// More improved code of the function but Big O of time complexity still O(n). Time complexity: seperate For loops is faster than nested.
function same(arr1, arr2)
{
    if(arr1.length !== arr2.length)
    {
        return false;
    }
    
    var frequncyCounter1 = {};
    var frequncyCounter2 = {};

    for(var val of arr1)
    {
       frequncyCounter1[val] = (frequncyCounter1[val] || 0) + 1;
    }

    for(var val of arr2)
    {
       frequncyCounter2[val] = (frequncyCounter2[val] || 0) + 1;
    }

    for(var key in frequncyCounter1)
    {
       if(!(key ** 2 in frequncyCounter2))
       {
           return false;
       }
       if(frequncyCounter2[key ** 2] !== frequncyCounter1[key])
       {
           return false;
       }
    }
    return true;
}


