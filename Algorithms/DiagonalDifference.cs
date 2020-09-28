public static int diagonalDifference(List<List<int>> arr)
{
    int row = 0;
    int col = 0;
    int lrsum = 0;
    int rlsum = 0;
    while(row < arr.Count){
        lrsum += arr[row][col];
        rlsum += arr[row][arr[0].Count-col-1];
        row++;
        col++;
    }
    int result = Math.Abs(lrsum-rlsum);
    return result;
}
