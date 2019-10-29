function multiply(arr, n) {
    var product = arr[0];
    for (var i = 1; i <= n; i++) {
        product *= arr[i];
    }
    console.log(product);
  }
multiply([10, 2, 3, 4], 0);
