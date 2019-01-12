function sameFrequency(arg1, arg2){
    
    if (arg1.toString().length !== arg2.toString().length) return false;
    
    let countObj = {};
    
    for (let num of arg1.toString()) 
    {
        if (countObj[num]) 
        {
            countObj[num]++;
        }
        else 
        {
            countObj[num] = 1;
        }
    }
    
    for (let item of arg2.toString()) {
        if (!countObj[item]) 
        {
            return false;
        }
        else 
        {
            countObj[item]--;
        }
    }
    
    for (let item in countObj) {
        if (countObj[item] > 0) 
        {
            return false;
        }
    }
    return true;
}



// Another approach
function sameFrequency(first, second) {

    if (first.toString().length !== second.toString().length) return false;

    let frequencies = {};
 
    let digit;
    while (first) {
        digit = first % 10;
        frequencies[digit] = ++frequencies[digit] || 1;
        first = Math.floor(first / 10);
    }
 
    while (second) {
        digit = second % 10;
        if (!frequencies[digit]--) {
            return false;
        }
        second = Math.floor(second / 10);
    }
    return true;
}
