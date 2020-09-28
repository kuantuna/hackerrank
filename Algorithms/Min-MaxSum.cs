static void miniMaxSum(int[] arr) {
    long minSum = 0;
    long maxSum = 0;
    Array.Sort(arr);
    for(int i = 0; i<arr.Count()-1; i++){
        minSum+=Convert.ToInt64(arr[i]);
    }
    Array.Reverse(arr);
    for(int i = 0; i<arr.Count()-1; i++){
        maxSum+=Convert.ToInt64(arr[i]);
    }
    Console.Write(minSum + " " + maxSum);
}
