int[] sortByHeight(int[] a) {
int[] r = new int[a.Length];   
int i=0;
    
// Define peoples.
IEnumerable<int> people = (from score in a where score > 0 select score).OrderBy(x => x);
    
    foreach(int item in a){
        if (item<0)
            r[i] = -1;
        else{
            r[i] = people.First();
            people = people.Skip(1);
            }
        i++;
    }

    return r;
}
