public static int birthdayCakeCandles(List<int> candles)
{
    int maxV = candles.Max();
    int count = 0;
    for(int i = 0; i<candles.Count; i++){
        if(maxV==candles[i]){
            count++;
        }
    }
    return count;
}
