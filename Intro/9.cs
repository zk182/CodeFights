string[] allLongestStrings(string[] inputArray) {
    int max = 0;
    int i = 0;
    string[] r = new string[10];
    foreach (string item in inputArray){
       if (item.Length>max){
           max = item.Length;
           Array.Clear(r,0,9);
           i = 0;
           r[i] = item;
           i++;
       }
       else if(item.Length==max){
           r[i] = item;
           i++;
       }
    }
    return r.Where(c => c != null).ToArray();
}
