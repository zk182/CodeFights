int commonCharacterCount(string s1, string s2) {
    int r=0;
    char[] a = s1.ToCharArray();
    Array.Sort(a);
    char[] b = s2.ToCharArray();
    Array.Sort(b);
    
    for (int i=0; i<s1.Length; i++){
        if (a[i] == b[0]){
            b = b.Skip(1).ToArray();
            r++;
        }
        else if (b.Contains(a[i])){
            b = b.Skip(Array.IndexOf(b,a[i])+1).ToArray();             
            r++;
        }
    }
    
    return r;
}
