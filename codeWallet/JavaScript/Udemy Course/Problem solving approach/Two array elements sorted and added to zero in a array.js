//Problem: Write a function called sumZero which accepts a sorted array integers. The function should find the first pair where the sum is
// 0. Returns an array that includes both values that sum to zero or undefined is a pair does not exist. E.g
// sumZero([-3, -2, -1, 0, 1, 2, 3]) //[-3, 3]
//sumZero([-2, 0, 1, 3]) //Undefined
//sumZero(1, 2, 3) //Undefined

//    The Naive approach O(n^2).
function SumZero(arr)
{
    for(var i = 0; i < arr.length; i++)
    {
        for(var j = i+1; j < arr.length; j++)
        {
            if(arr[i] + arr[j] === 0)
            {
                return [arr[i], arr[j]];
            }
        }
    }
}


//   More optimized for speed.
function SumZeroRefactor(arr)
{
    var left = 0;
    var right = arr.length - 1;
    while(left < right)
    {
        var sum = arr[left] + arr[right];
        if(sum === 0)
        {
            return [arr[left], arr[right]];
        }
        else if(sum > 0)
        {
            right--;
        }
        else
        {
            left++;
        }
    }
}
