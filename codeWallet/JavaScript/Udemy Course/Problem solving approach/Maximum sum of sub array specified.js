// The naive method
function MaxSubArraySum(arr, num)
{
    if(num > arr.length)
    {
        return null;
    }

    var max = -Infinity;
    for(var i = 0; i < ((arr.length - num) + 1); i++)
    {
        var temp = 0;
        for(var j = 0; j < num; j++)
        {
            temp = temp + arr[i + j];
        }

        if(temp > max)
        {
            max = temp;
        } 
        console.log(temp, max);
    }

    return max;
}


//Refactored. Time Complexity O(n)
function MaxSubArraySum(arr, num)
{
    var maxSum = 0;
    var tempSum = 0;
    if(arr.length < num) 
    {
         return null;
    }

    for(var i = 0; i < num; i++)
    {
        maxSum += arr[i];
    }
    tempSum = maxSum;

     for(var i = num; i < arr.length; i++)
    {
        tempSum = tempSum - arr[i - num] + arr[i];
        maxSum = Math.max(maxSum, tempSum);
    }
    return maxSum;
}
