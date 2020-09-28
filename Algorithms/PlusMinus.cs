static void plusMinus(int[] arr) {
    double posCount = 0.0;
    double zCount = 0.0;
    double negCount = 0.0;
    for(int i = 0; i<arr.Count(); i++){
        if(arr[i]>0){
            posCount++;
        }
        else if(arr[i]==0){
            zCount++;
        }
        else{
            negCount++;
        }
    }
    double posR = Convert.ToDouble(posCount/arr.Count());
    double negR = Convert.ToDouble(negCount/arr.Count());
    double zR = Convert.ToDouble(zCount/arr.Count());
    Console.WriteLine(posR);
    Console.WriteLine(negR);
    Console.WriteLine(zR);
}
