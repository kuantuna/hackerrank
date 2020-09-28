static List<int> compareTriplets(List<int> a, List<int> b) {
    List<int> comp = new List<int>();
    comp.Add(0);
    comp.Add(0);
    for(int i = 0; i<a.Count; i++){
        if(a.ElementAt(i) > b.ElementAt(i)){
            comp[0]++;
        }
        else if(a.ElementAt(i) == b.ElementAt(i)){}
        else{
            comp[1]++;
        }
    }
    return comp;
}
