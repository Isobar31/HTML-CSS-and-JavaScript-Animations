function searchForIndex(arr, val)
{    
    for(var i = 0; i < arr.length; i++)
    {     
        if(arr[i] === val)
        {
            return i;
        }
    } 
    return -1;   
}


// The refactored method. Time complexity log(n)
function searchForIndex(arr, val)
{    
    var min = 0;
    var max = arr.length -1;

    while(min <= max)
    {
        var middle = Math.floor((min + max)/2);
        //var currentElement = arr[middle];

        if(arr[middle] < val)
        {
            min = middle +1;
        }
        else if(arr[middle] > val)
        {
            max = middle -1;
        }
        else
       { 
           return middle;
        }
    }
    return -1;   
}
