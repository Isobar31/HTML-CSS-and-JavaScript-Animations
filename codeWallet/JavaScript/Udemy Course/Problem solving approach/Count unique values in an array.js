// First approach
function countUniqueValues(arr){
    let obj = {};
    let size = 0;
    for(let e of arr){
        if(obj[e]){
            obj[e]++;
        }
        else {
            obj[e] = 1;
        }
    }
    for(let key in obj){
        if(obj.hasOwnProperty(key)) size++;
    }
    return size;
}


// The main refactored solution
 function countUniqueValues(arr) 
    {
        if(arr.length === 0) return 0;

        var i = 0;
        for(var j = 1; j < arr.length; j++)
        {
            if(arr[i] !== arr[j])
            {
                i++;
                arr[i] = arr[j];
            }
        }
        return i + 1;
    }
