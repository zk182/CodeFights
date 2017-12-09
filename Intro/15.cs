string[] addBorder(string[] picture) {
    string[] r = new string[picture.Length+2];
    int i = 1;
    for (int j=1; j<=picture[0].Length + 2; j++){
        r[0] = r[0]+"*"; 
        r[r.Length-1] = r[r.Length-1]+"*";
    }
        
    foreach(string item in picture){
        r[i] = "*" + item + "*";
        i++;
    }
    return r;
}
