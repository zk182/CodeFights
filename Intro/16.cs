bool areSimilar(int[] a, int[] b) {
    var happn = false;
    var skip = 0;
    if (!a.SequenceEqual(b)){
       int i = 0;
       foreach(int item in a){
           if (item != b[i]){
               if (i != skip) {
                   if (happn) return false;
                   for(int j=0;j<b.Length;j++){
                       if (b[j] == item && a[j] == b[i]){    
                           happn = true;
                           skip = j;
                           break;
                       }
                       else if (j+1 == b.Length)
                           return false;
                   }
               }
           }
           i++;
       }         
    }
    return true;
}
